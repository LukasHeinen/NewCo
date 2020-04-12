using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace clicky_clicky.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class SurveyController : ControllerBase
    {
        [HttpGet("surveys/{id}")]
        public SurveyResponse GetSurvey(Guid id)
        {
            return new ResolvedSurveyResponse()
            {
                Id = id,
                ImageUrl = "",
                Question = "Where is Simon?",
                CreatorName = "Admin",
                Solution = new Point
                {
                    X = 50,
                    Y = 50
                }

            };
        }

        [HttpPost("surveys/{id}/tips")]
        public void PostTip(Guid id, [FromBody] TipRequest tip)
        {
            throw new NotImplementedException();
        }
    }

    public class Survey
    {
        public Guid id;
        public string Question;
        public string CreatorId;
        public string ImageId;
        public Point Solution;
        public IList<Tip> Tips;
        public bool IsRevealed;
        public bool showResultsAfterTip;
    }

    public class Tip
    {
        public Guid UserId;
        public Point Point;
    }

    public class Point
    {
        public uint X;
        public uint Y;
    }

    public class TipRequest
    {
        public Point point;
    }

    public class SurveyResponse
    {
        public Guid Id;
        public string CreatorName;
        public string Question;
        public string ImageUrl;
    }

    public class ResolvedSurveyResponse : SurveyResponse
    {
        public IList<TipResponse> Tips;
        public Point Solution;
    }

    public class TipResponse
    {
        public string UserName;
        public Point Point;
    }
}
