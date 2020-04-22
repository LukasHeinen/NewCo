using System.Collections.Generic;
using clicky_clicky.Surveys.Models;

namespace clicky_clicky.Surveys.Application.ViewModels
{
    public class ResolvedSurveyView : SurveyView
    {
        public IList<TipView> Tips { get; set; }
        public Point Solution { get; set; }
    }
}
