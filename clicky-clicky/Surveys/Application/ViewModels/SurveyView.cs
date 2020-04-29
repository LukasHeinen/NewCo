using System;
using System.Collections.Generic;
using System.Drawing;

namespace clicky_clicky.Surveys.Application.ViewModels
{
    public class SurveyView
    {
        public Guid Id { get; set; }
        public UserView Creator { get; set; }
        public string Question { get; set; }
        public string ImageUrl { get; set; }
    }

    public class ResolvedSurveyView : SurveyView
    {
        public IList<TipView> Tips { get; set; }
        //public Point Solution { get; set; }
    }
}
