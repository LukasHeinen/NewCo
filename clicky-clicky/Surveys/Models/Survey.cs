using System;
using System.Collections.Generic;

namespace clicky_clicky.Surveys.Models
{
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
}
