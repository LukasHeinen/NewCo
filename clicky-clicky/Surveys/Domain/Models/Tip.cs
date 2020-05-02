using System;
using System.Drawing;
using Microsoft.Azure.Cosmos.Table;

namespace clicky_clicky.Surveys.Domain.Models
{
    public class Tip : TableEntity
    {
        public Tip() { }
        public Tip(string surveyId, string userId)
        {
            UserId = userId;
            SurveyId = surveyId;
        }

        public string UserId
        {
            get { return RowKey; }
            set { RowKey = value; }
        }

        public string SurveyId
        {
            get { return PartitionKey; }
            set { PartitionKey = value; }
        }

        public Point Point { get; set; }
    }
}
