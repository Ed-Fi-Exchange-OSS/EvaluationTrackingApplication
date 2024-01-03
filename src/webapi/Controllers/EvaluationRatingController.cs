// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using eppeta.webapi.Evaluations.Data;
using eppeta.webapi.Evaluations.Models;
using eppeta.webapi.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using eppeta.webapi.Identity.Models;
using eppeta.webapi.Mapping;
using eppeta.webapi.Service;
using EdFi.OdsApi.Sdk.Models.All;
using OpenIddict.Abstractions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eppeta.webapi.Controllers
{
    //    [Authorize(AuthenticationSchemes = OpenIddictValidationAspNetCoreDefaults.AuthenticationScheme)]
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluationRatingController : ControllerBase
    {
        private readonly IODSAPIAuthenticationConfigurationService _service;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEvaluationRepository _evaluationRepository;
        private readonly IOpenIddictTokenManager _tokenManager;
        private readonly string _resultDatatype = "uri://ed-fi.org/ResultDatatypeTypeDescriptor#Integer";

        public EvaluationRatingController(IODSAPIAuthenticationConfigurationService service, UserManager<ApplicationUser> userManager, IEvaluationRepository evaluationRepository, IOpenIddictTokenManager tokenManager)
        {
            _service = service;
            _userManager = userManager;
            _evaluationRepository = evaluationRepository;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<PerformedEvaluation>>> GetPerformedEvaluations()
        {
            var evaluationRatings = await _evaluationRepository.GetAllEvaluationRatings();
            List<PerformedEvaluation> perEvalRatings = new List<PerformedEvaluation>();

            foreach (var evalRating in evaluationRatings)
            {
                var perEvaluation = (PerformedEvaluation)evalRating;
                var perEvalRatingDB = (await _evaluationRepository.GetPerformanceEvaluationRatingsByPK(evalRating)).FirstOrDefault();
                if (perEvalRatingDB != null)
                {
                    perEvaluation.EvaluationStatus = perEvalRatingDB.RecordStatus != null ? perEvalRatingDB.RecordStatus.StatusText : "Not Uploaded";
                    perEvaluation.EvaluatorName = perEvalRatingDB.EvaluatorName;
                    perEvaluation.ReviewedCandidateName = perEvalRatingDB.ReviewedCandidateName;
                }
                perEvalRatings.Add(perEvaluation);
            }

            return Ok(perEvalRatings);
        }

        [HttpGet("{userId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<PerformedEvaluation>>> GetPerformedEvaluations([FromRoute] string userId)
        {
            if (userId is null || userId == string.Empty) { return NotFound(); }
            var evaluationRatings = await _evaluationRepository.GetEvaluationRatingsByUserId(userId);
            List<PerformedEvaluation> perEvalRatings = new List<PerformedEvaluation>();

            foreach (var evalRating in evaluationRatings)
            {
                var perEvaluation = (PerformedEvaluation)evalRating;
                var perEvalRatingDB = (await _evaluationRepository.GetPerformanceEvaluationRatingsByPK(evalRating)).FirstOrDefault();
                if (perEvalRatingDB != null)
                {
                    perEvaluation.EvaluationStatus = perEvalRatingDB.RecordStatus != null ? perEvalRatingDB.RecordStatus.StatusText : "Not Uploaded";
                    perEvaluation.EvaluatorName = perEvalRatingDB.EvaluatorName;
                    perEvaluation.ReviewedCandidateName = perEvalRatingDB.ReviewedCandidateName;
                }
                perEvalRatings.Add(perEvaluation);
            }

            return Ok(perEvalRatings);
        }

        /// <summary>
        /// Saves the evaluation objects
        /// </summary>
        /// <param name="evaluationResult">Performed evaluation results</param>
        /// <param name="userId">User id</param>
        /// <returns>Dictionary of the evaluation objects types created/updated and their ids</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private async Task<Dictionary<string, List<int>>> SaveEvaluation(PerformedEvaluationResult evaluationResult, string userId)
        {
            if (evaluationResult == null || evaluationResult.ObjectiveResults == null || evaluationResult.ObjectiveResults.Count < 1)
                throw new ArgumentNullException(nameof(evaluationResult));
            // this dict stores the list of Ids created/updated for each object type while saving just in case we need them later
            var result = new Dictionary<string, List<int>>() {
                { typeof(PerformanceEvaluationRating).Name, new List<int>{ } },
                { typeof(EvaluationRating).Name, new List<int>{ } },
                { typeof(EvaluationObjectiveRating).Name, new List<int>{ } },
                { typeof(EvaluationElementRatingResult).Name, new List<int>{ } },
            };
            
            PerformanceEvaluation? perEval = null;
            DateTime evaluationDate = DateTime.UtcNow;

            if (evaluationResult.EvaluationRatingId > 0)
            {
                perEval = await _evaluationRepository.GetPerformanceEvaluationById(evaluationResult.EvaluationId);
                var evalRating = await _evaluationRepository.GetEvaluationRatingById(evaluationResult.EvaluationRatingId);
                if (evalRating != null)
                {
                    evaluationDate = evalRating.EvaluationDate;
                    userId = evalRating.UserId;
                }
            }
            else
            {
                perEval = await _evaluationRepository.GetPerformanceEvaluationById(evaluationResult.EvaluationId);
                if (perEval == null)
                    throw new ArgumentException("PerformanceEvaluation not found");
            }

            // Create EvaluationRating
            var evalObjective = await _evaluationRepository.GetEvaluationObjectiveById(evaluationResult.ObjectiveResults.First().Id);

            var newEvalRating = new EvaluationRating();
            MappingHelper.CopyMatchingPKProperties(perEval, newEvalRating);
            newEvalRating.SourceSystemDescriptor = evaluationResult.ReviewedPersonSourceSystemDescriptor;
            newEvalRating.EvaluationDate = evaluationDate;
            newEvalRating.EvaluationTitle = evalObjective.EvaluationTitle;
            newEvalRating.PersonId = evaluationResult.ReviewedPersonId;
            newEvalRating.UserId = userId;

            result[newEvalRating.GetType().Name].AddRange(await _evaluationRepository.UpdateEvaluationRatings(new List<EvaluationRating> { newEvalRating }));

            // Create PerformanceEvaluationRating
            var perEvalRating = new PerformanceEvaluationRating();
            MappingHelper.CopyMatchingPKProperties(perEval, perEvalRating);

            perEvalRating.ReviewedCandidateName = evaluationResult.ReviewedCandidateName;
            perEvalRating.EvaluatorName = evaluationResult.EvaluatorName;
            perEvalRating.PersonId = evaluationResult.ReviewedPersonId;
            perEvalRating.SourceSystemDescriptor = evaluationResult.ReviewedPersonSourceSystemDescriptor;
            perEvalRating.EndTime = evaluationResult.EndDateTime ?? evaluationDate;
            perEvalRating.UserId = userId;
            perEvalRating.StartTime = evaluationDate;

            result[perEvalRating.GetType().Name].AddRange(
                await _evaluationRepository.UpdatePerformanceEvaluationRatings(new List<PerformanceEvaluationRating> { perEvalRating }));

            foreach (var objRes in evaluationResult.ObjectiveResults)
            {
                // Create or Update EvaluationObjectiveRating
                evalObjective = await _evaluationRepository.GetEvaluationObjectiveById(objRes.Id);

                var objRating = new EvaluationObjectiveRating();
                MappingHelper.CopyMatchingPKProperties(evalObjective, objRating);

                objRating.SourceSystemDescriptor = evaluationResult.ReviewedPersonSourceSystemDescriptor;
                objRating.EvaluationDate = evaluationDate;
                objRating.Comments = objRes.Comment;
                objRating.PersonId = evaluationResult.ReviewedPersonId;
                objRating.UserId = userId;

                result[objRating.GetType().Name].AddRange(await _evaluationRepository.UpdateEvaluationObjectiveRatings(new List<EvaluationObjectiveRating> { objRating }));

                foreach (var elRes in objRes.Elements)
                {
                    var evalElement = await _evaluationRepository.GetEvaluationElementById(elRes.Id);
                    var elementRatingResult = new EvaluationElementRatingResult();
                    MappingHelper.CopyMatchingPKProperties(evalElement, elementRatingResult);

                    elementRatingResult.SourceSystemDescriptor = evaluationResult.ReviewedPersonSourceSystemDescriptor;
                    elementRatingResult.EvaluationDate = evaluationDate;
                    elementRatingResult.PersonId = evaluationResult.ReviewedPersonId;
                    elementRatingResult.ResultDatatypeTypeDescriptor = _resultDatatype; // TODO: harcoding this based on the type of elRes.Score
                    elementRatingResult.RatingResultTitle = evalElement.EvaluationElementTitle.Substring(0, Math.Min(50, evalElement.EvaluationElementTitle.Length)); // TODO: No result title is returned from frontend. Truncating element title
                    elementRatingResult.Rating = elRes.Score;
                    elementRatingResult.UserId = userId;

                    result[elementRatingResult.GetType().Name].AddRange(await _evaluationRepository.UpdateEvaluationElementRatingResults(new List<EvaluationElementRatingResult> { elementRatingResult }));
                }
            }
            return result;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Save(PerformedEvaluationResult evaluationResult, string userId)
        {
            try
            {
                var ids = await SaveEvaluation(evaluationResult, userId);
                return Ok(ids);
            }
            catch(ArgumentException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        [HttpPost]
        [Route("Approve")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Approve(PerformedEvaluationResult evaluationResult, string userId)
        {
            var apiList = new List<string> {
                    "PerformanceEvaluationsApi",
                    "PerformanceEvaluationRatingsApi",
                    "EvaluationsApi",
                    "EvaluationObjectivesApi",
                    "EvaluationElementsApi",
                    "EvaluationObjectiveRatingsApi",
                    "EvaluationRatingsApi",
                    "EvaluationElementRatingsApi",
                };
            // build dict with APIs
            var apis = new Dictionary<string, dynamic>();
            var authenticatedConfiguration = _service.GetAuthenticatedConfiguration().Result;
            foreach (var api in apiList)
            {
                var apiClassType = Type.GetType($"EdFi.OdsApi.Sdk.Apis.All.{api},EdFi.OdsApi.Sdk");
                if (apiClassType == null)
                    throw new Exception($"Missing API class for {api}");
                apis[api] = Activator.CreateInstance(apiClassType, new object[] { authenticatedConfiguration });
                apis[api].Configuration.DefaultHeaders.Add("Content-Type", "application/json");
            }
            PerformanceEvaluationRating? performanceEvaluationRatingPost = null;
            try
            {
                // Make sure the evaluation objects are saved before posting to EdFi API
                var ids = await SaveEvaluation(evaluationResult, userId);
                // Make sure data dependencies are met
                var performanceEvaluationPost = await _evaluationRepository.GetPerformanceEvaluationById(evaluationResult.EvaluationId);
                // POST performanceEvaluation
                var res = await apis["PerformanceEvaluationsApi"].PostPerformanceEvaluationWithHttpInfoAsync((TpdmPerformanceEvaluation)performanceEvaluationPost);
                if (res.ErrorText != null)
                    throw new Exception(res.ErrorText);
                performanceEvaluationRatingPost = await _evaluationRepository.GetPerformanceEvaluationRatingById(ids[typeof(PerformanceEvaluationRating).Name].First());

                // POST performanceEvaluationRating
                res = await apis["PerformanceEvaluationRatingsApi"].PostPerformanceEvaluationRatingWithHttpInfoAsync((TpdmPerformanceEvaluationRating)performanceEvaluationRatingPost);
                if (res.ErrorText != null)
                    throw new Exception(res.ErrorText);
                foreach (var evaluationObjectiveRatingId in ids[typeof(EvaluationObjectiveRating).Name])
                {
                    var evaluationObjectiveRatingPost = await _evaluationRepository.GetEvaluationObjectiveRatingById(evaluationObjectiveRatingId);
                    // POST Evaluation
                    res = await apis["EvaluationsApi"].PostEvaluationWithHttpInfoAsync((TpdmEvaluation)evaluationObjectiveRatingPost);
                    if (res.ErrorText != null)
                        throw new Exception(res.ErrorText);
                    // POST EvaluationRating
                    res = await apis["EvaluationRatingsApi"].PostEvaluationRatingWithHttpInfoAsync((TpdmEvaluationRating)evaluationObjectiveRatingPost);
                    if (res.ErrorText != null)
                        throw new Exception(res.ErrorText);
                    // POST evaluationObjectiveRating
                    res = await apis["EvaluationObjectiveRatingsApi"].PostEvaluationObjectiveRatingWithHttpInfoAsync((TpdmEvaluationObjectiveRating)evaluationObjectiveRatingPost);
                    if (res.ErrorText != null)
                        throw new Exception(res.ErrorText);
                }
                foreach (var evaluationElementRatingResultId in ids[typeof(EvaluationElementRatingResult).Name])
                {
                    var evaluationElementRatingResultPost = await _evaluationRepository.GetEvaluationElementRatingResultById(evaluationElementRatingResultId);
                    // POST evaluationElement
                    var evaluationElementPost = new EvaluationElement();
                    MappingHelper.CopyMatchingPKProperties(evaluationElementRatingResultPost, evaluationElementPost);
                    res = await apis["EvaluationElementsApi"].PostEvaluationElementWithHttpInfoAsync((TpdmEvaluationElement)evaluationElementPost);
                    if (res.ErrorText != null)
                        throw new Exception(res.ErrorText);
                    // POST evaluationElementRating
                    var evaluationElementRatingPost = new EvaluationElementRating();
                    MappingHelper.CopyMatchingPKProperties(evaluationElementRatingResultPost, evaluationElementRatingPost);
                    evaluationElementRatingPost.EvaluationElementTitle = evaluationElementPost.EvaluationElementTitle;
                    evaluationElementRatingPost.EvaluationObjectiveTitle = evaluationElementPost.EvaluationObjectiveTitle;
                    evaluationElementRatingPost.PersonId = evaluationResult.ReviewedPersonId;
                    evaluationElementRatingPost.SourceSystemDescriptor = evaluationResult.ReviewedPersonSourceSystemDescriptor;
                    evaluationElementRatingPost.EvaluationDate = evaluationResult.StartDateTime;
                    var tpdmEvaluationElementRatingPost = (TpdmEvaluationElementRating)evaluationElementRatingPost;
                    tpdmEvaluationElementRatingPost.Results = new List<TpdmEvaluationElementRatingResult>{
                        new TpdmEvaluationElementRatingResult
                        (
                            rating: (double)evaluationElementRatingResultPost.Rating,
                            ratingResultTitle: evaluationElementPost.EvaluationElementTitle.Length > 50? evaluationElementPost.EvaluationElementTitle.Substring(0,50): evaluationElementPost.EvaluationElementTitle,
                            resultDatatypeTypeDescriptor: _resultDatatype
                        )};
                    res = await apis["EvaluationElementRatingsApi"].PostEvaluationElementRatingWithHttpInfoAsync(tpdmEvaluationElementRatingPost);
                    if (res.ErrorText != null)
                        throw new Exception(res.ErrorText);
                }
                performanceEvaluationRatingPost.StatusId = (await _evaluationRepository.GetStatusByText("uploaded")).Id;
                await _evaluationRepository.UpdatePerformanceEvaluationRatings(new List<PerformanceEvaluationRating> { performanceEvaluationRatingPost });
                return Ok(ids);
            }

            catch (ArgumentException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception ex)
            {
                if (performanceEvaluationRatingPost != null)
                {
                    performanceEvaluationRatingPost.StatusId = (await _evaluationRepository.GetStatusByText("failed")).Id;
                    await _evaluationRepository.UpdatePerformanceEvaluationRatings(new List<PerformanceEvaluationRating> { performanceEvaluationRatingPost });
                }
                return Problem(ex.Message);
            }
        }
    }
}
