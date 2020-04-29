using System.Threading.Tasks;
using clicky_clicky.Surveys.Models;
using clicky_clicky.Utils.AzureTableStorage;

namespace clicky_clicky.Surveys
{
    public class SurveyService : ISurveyService
    {
        private readonly IAzureTableStorage<Survey> repository;

        public SurveyService(IAzureTableStorage<Survey> repository)
        {
            this.repository = repository;
        }

        public Task CreateSurvey(Survey survey)
        {
            throw new System.NotImplementedException();
        }
    }
}
