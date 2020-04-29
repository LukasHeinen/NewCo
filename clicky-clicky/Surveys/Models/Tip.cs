using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.Azure.Cosmos.Table;

namespace clicky_clicky.Surveys.Models
{
    public class Tip : TableEntity
    {
        public Tip (Guid surveyId, Guid userId)
        {
            SurveyId = surveyId;
            UserId = userId;
            RowKey = userId.ToString();
            PartitionKey = surveyId.ToString();
        }

        public Guid UserId { get; }

        public Guid SurveyId { get; }

        public Point Point { get; set; }
    }
}
