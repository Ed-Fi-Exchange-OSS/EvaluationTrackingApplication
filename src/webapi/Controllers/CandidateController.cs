// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using EdFi.OdsApi.Sdk.Apis.All;
using eppeta.webapi.DTO;
using eppeta.webapi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eppeta.webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly IODSAPIAuthenticationConfigurationService _service;
        public CandidateController(IODSAPIAuthenticationConfigurationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Dictionary<string, List<string>>>> GetCandidates()
        {
            // Get ODS/API token
            var authenticatedConfiguration = await _service.GetAuthenticatedConfiguration();

            var candidatesApi = new CandidatesApi(authenticatedConfiguration);
            candidatesApi.Configuration.DefaultHeaders.Add("Content-Type", "application/json");
            //TODO remove limit and filter by current term and school year
            var candidates = await candidatesApi.GetCandidatesAsync(limit: 25, offset: 0);
            var candidatesDictionary = new List<Candidate>();

            candidatesDictionary = candidates.Where(x => x.PersonReference is not null).Select(x => new Candidate { CandidateName = $"{x.FirstName} {x.LastSurname}", PersonId = x.PersonReference.PersonId, SourceSystemDescriptor = x.PersonReference.SourceSystemDescriptor }).ToList();

            return Ok(candidatesDictionary);
        }
    }
}
