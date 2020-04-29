using System.Threading.Tasks;
using clicky_clicky.Surveys.Models;

namespace clicky_clicky.Surveys
{
    public interface ISurveyService
    {
        Task CreateSurvey(Survey survey);
    }
}
