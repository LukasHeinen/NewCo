using System;

namespace clicky_clicky.Surveys.Application.ViewModels
{
    public class SurveyView
    {
        public Guid Id { get; set; }
        public UserView Creator { get; set; }
        public string Question { get; set; }
        public string ImageUrl { get; set; }
    }
}
