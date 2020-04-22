using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using clicky_clicky.Surveys.Application.ViewModels;
using clicky_clicky.Surveys.Application.RequestModels;
using Microsoft.AspNetCore.Http;

namespace clicky_clicky.Surveys.Application
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class SurveysController : ControllerBase
    {
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
        /// Additional description
        /// </remarks>
        /// <param name="survey"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>            ]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public void CreateSurvey([FromBody] SurveyRequest survey)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{id}/tips")]
        public void PostTip(Guid id, [FromBody] TipRequest tip)
        {
            throw new NotImplementedException();
        }

    }
}
