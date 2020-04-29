using System;
using System.Collections.Generic;
using System.Drawing;
using Microsoft.Azure.Cosmos.Table;

namespace clicky_clicky.Surveys.Models
{
    public class Survey : TableEntity
    {
        public Survey () {}
        public Survey (string creatorId)
        {
            Id = Guid.NewGuid();
            PartitionKey = creatorId;
            RowKey = Id.ToString();
        }
        public Guid Id { get; }
        public string CreatorId { get; }
        public string Question { get; set; }
        public bool ShowResolution { get; set; }
    }
}