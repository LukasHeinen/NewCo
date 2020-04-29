using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using clicky_clicky.Surveys.Application.ViewModels;
using clicky_clicky.Surveys.Application.RequestModels;
using Microsoft.AspNetCore.Http;
using clicky_clicky.Surveys.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace clicky_clicky.Surveys.Application
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class SurveysController : ControllerBase
    {
        private readonly ISurveyService _service;

        public SurveysController(ISurveyService service)
        {
            _service = service;
        }
        [HttpGet]
        public IEnumerable<SurveyView> GetMySurveys()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public SurveyView GetSurvey(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new survey with a image upload.
        /// </summary>
        /// <remarks>
        /// This endpoint will use the Authenticated Users Id as CreatorId.
        /// </remarks>
        /// <param name="surveyRequest"></param>
        /// <returns>A view on the created survey</returns>
        /// <response code="201">Returns the view on the created survey</response>
        /// <response code="400">If required properties are not supplied</response>            ]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        [Authorize]
        public SurveyView CreateSurvey([FromBody] SurveyRequest surveyRequest)
        {
            var userId = GetUserId();
            
            var survey = new Survey(userId)
            {
                Question = surveyRequest.Question,
                ShowResolution = surveyRequest.ShowResolutionAfterTip
            };
            _service.CreateSurvey(survey);
            
            //Todo: store image (surveyRequest.Image) --> use survey.Id
            throw new NotImplementedException();
        }

        [HttpPost("{id}/tips")]
        public void PostTip(Guid id, [FromBody] TipRequest tip)
        {
            throw new NotImplementedException();
        }

        private string GetUserId ()
        {
            var claimsPrincial = (ClaimsPrincipal)User;
            return claimsPrincial.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

    }
}
