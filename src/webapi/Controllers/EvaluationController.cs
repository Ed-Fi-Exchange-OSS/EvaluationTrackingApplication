// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using EdFi.OdsApi.Sdk.Apis.All;
using Microsoft.AspNetCore.Mvc;
using EdFi.OdsApi.Sdk.Client;
using eppeta.webapi.Service;
using EdFi.OdsApi.SdkClient;
using eppeta.webapi.Evaluations.Data;
using eppeta.webapi.Evaluations.Models;
using EdFi.OdsApi.Sdk.Models.All;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Caching.Memory;
using eppeta.webapi.DTO;
using System.Linq.Dynamic.Core;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EvaluationController : ControllerBase
{
    private readonly IODSAPIAuthenticationConfigurationService _service;
    private readonly IEvaluationRepository _evaluationRepository;
    private readonly IMemoryCache _memoryCache;
    private string dataExpirationKey = "DataExpiration";
    private TimeSpan dataExpirationInterval = TimeSpan.FromDays(1);

    public EvaluationController(IODSAPIAuthenticationConfigurationService service, IEvaluationRepository evaluationRepository, IMemoryCache memoryCache)
    {
        _service = service;
        _evaluationRepository = evaluationRepository;
        _memoryCache = memoryCache;
    }

    [HttpGet("configuration")]
    public Configuration GetAuthenticatedConfiguration()
    {
        var authenticatedConfiguration = _service.GetAuthenticatedConfiguration();
        return authenticatedConfiguration;
    }

    // GET: api/EvaluationApi
    // The GetEvaluation method is slow due to the need to retrieve configuration first
    // TODO: Get the evaluation elements in the same method as GetEvaluation()
    [HttpGet]
    public async Task<ActionResult<List<AvailableEvaluationObjective>>> GetEvaluationObjectivesElementsTitles()
    {
        try
        {
            // Check if already synced dependecies in cache
            if (_memoryCache.Get(dataExpirationKey) == null)
            {
                // Refresh Evaluation data from API
                // Get ODS/API token
                var authenticatedConfiguration = _service.GetAuthenticatedConfiguration();

                //// Get Evaluation Objectives and update repository
                var objectivesApi = new EvaluationObjectivesApi(authenticatedConfiguration);
                objectivesApi.Configuration.DefaultHeaders.Add("Content-Type", "application/json");
                var tpdmEvaluationObjectives = await objectivesApi.GetEvaluationObjectivesAsync(limit: 100, offset: 0);
                await _evaluationRepository.UpdateEvaluationObjectives(tpdmEvaluationObjectives.Select(teo => (EvaluationObjective)teo).ToList());

                // Get Evaluation Elements which contain the EvaluationObjectiveTitles and update repository
                var elementsApi = new EvaluationElementsApi(authenticatedConfiguration);
                elementsApi.Configuration.DefaultHeaders.Add("Content-Type", "application/json");
                var tpdmEvaluationElements = await elementsApi.GetEvaluationElementsAsync(limit: 100, offset: 0);
                await _evaluationRepository.UpdateEvaluationElements(tpdmEvaluationElements.Select(tee => (EvaluationElement)tee).ToList());

                var peApi = new PerformanceEvaluationsApi(authenticatedConfiguration);
                peApi.Configuration.DefaultHeaders.Add("Content-Type", "application/json");
                var tpdmPerformanceEvaluations = await peApi.GetPerformanceEvaluationsAsync(limit: 100, offset: 0);
                await _evaluationRepository.UpdatePerformanceEvaluations(tpdmPerformanceEvaluations.Select(pe => (PerformanceEvaluation)pe).ToList());

                // set next expiration time
                var cachedValue = _memoryCache.GetOrCreate(
                    dataExpirationKey,
                    cacheEntry =>
                    {
                        cacheEntry.AbsoluteExpirationRelativeToNow = dataExpirationInterval;
                        return DateTime.Now;
                    });
            }
            // use dynamic Linq to join on matching column names
            string[] nonJoinCols = { "EdFiId", "Id", "CreateDate", "LastModifiedDate" };
            var evaluationObjectives = await _evaluationRepository.GetAllEvaluationObjectives();
            var evaluationElements = await _evaluationRepository.GetAllEvaluationElements();
            var evaluationObjectivesCols = typeof(EvaluationObjective).GetProperties().Select(f => f.Name).ToList();
            var evaluationElementsCols = typeof(EvaluationElement).GetProperties().Select(f => f.Name).ToList();
            var matchingCols = evaluationObjectivesCols.Where(c => evaluationElementsCols.Contains(c) && !nonJoinCols.Contains(c)).ToArray();
            var availableObjectives = evaluationObjectives.AsQueryable().GroupJoin(
                evaluationElements.AsQueryable(),
                "new {" + string.Join(",", matchingCols) + "}",
                "new {" + string.Join(",", matchingCols) + "}",
                "new (outer.Id, outer.EvaluationObjectiveTitle, inner as elements)").ToDynamicList();
            var availableEvaluationObjectives = new List<AvailableEvaluationObjective>();
            foreach (var availableObjective in availableObjectives)
            {
                AvailableEvaluationObjective naeo = new AvailableEvaluationObjective
                {
                    Name = availableObjective.EvaluationObjectiveTitle,
                    EvaluationObjectiveId = availableObjective.Id
                };
                foreach (EvaluationElement el in availableObjective.elements)
                {
                    naeo.EvaluationElements.Add(new AvailableEvaluationObjective.AvailableEvaluationElement
                    {
                        Name = el.EvaluationElementTitle,
                        EvaluationElementId = el.Id
                    });
                }
                availableEvaluationObjectives.Add(naeo);
            }
            return Ok(availableEvaluationObjectives);
        }

        // temporary for debugging
        // TODO: Remove this catch block and add logging middleware EPPETA-25
        catch (Exception ex)
        {
#pragma warning disable CA2200 // Rethrow to preserve stack details
            throw ex;
#pragma warning restore CA2200 // Rethrow to preserve stack details
        }
    }

}
