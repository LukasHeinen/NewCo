using System;
using Microsoft.Azure.Cosmos.Table;
using System.Text.RegularExpressions;
using System.Linq;

namespace clicky_clicky.Surveys.Domain.Models
{
    public class Survey : TableEntity
    {
        private string _question;
        public Survey() {}

        public string Id
        {
            get { return RowKey; }
            set { RowKey = value; }
        }

        public string CreatorId { get; set; }
        public string Question { get {return _question;} set { _question = value?.Trim(' '); }}

        public bool ShowSolution { get; set; } = false;

        public bool IsValid()
        {
            return 
                IsValidCreator() && 
                IsValidQuestion();
        }

        private bool IsValidCreator()
        {
            var rx = new Regex(@"[\w]*[ \t]+[\w]*", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            return !String.IsNullOrWhiteSpace(this.CreatorId) && !rx.Matches(this.CreatorId).Any();
        }

        private bool IsValidQuestion() {
            return !String.IsNullOrWhiteSpace(this.Question);
        }
    }
}