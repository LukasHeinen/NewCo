
using clicky_clicky.Surveys.Application.RequestModels;
using clicky_clicky.Surveys.Application.ViewModels;
using clicky_clicky.Surveys.Domain.Models;

namespace clicky_clicky.Surveys.Application.Mappings
{
    public static class SurveyMapping
    {
        public static Survey ToEntity(this SurveyRequest surveyRequest)
        {
            return new Survey()
            {
                Question = surveyRequest.Question,
                ShowSolution = surveyRequest.ShowResolutionAfterTip
            };
        }
    }
}