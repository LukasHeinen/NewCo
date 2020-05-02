using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.Azure.Cosmos.Table;

namespace clicky_clicky.Surveys.Domain.Models
{
    public class Participation : TableEntity
    {
        public Participation() { }
        public Participation(string userId, string surveyId)
        {
            UserId = userId;
            SurveyId = surveyId;
            PartitionKey = userId;
            RowKey = surveyId;
        }

        public string UserId { get; }
        public string SurveyId { get; }
    }
}