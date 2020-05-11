using System.Threading.Tasks;
using clicky_clicky.Surveys.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace clicky_clicky.Surveys.Domain
{
    public interface ISurveyService
    {
        Task CreateSurvey(Survey survey, IFormFile image);
    }
}
