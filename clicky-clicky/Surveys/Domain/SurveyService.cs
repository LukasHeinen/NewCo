using System.Threading.Tasks;
using clicky_clicky.Surveys.Domain.Models;
using clicky_clicky.Utils.AzureTableStorage;
using Microsoft.AspNetCore.Http;

namespace clicky_clicky.Surveys.Domain
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
            if (!survey.IsValid()) {
                
            }
            //save Table
            //save Image

            throw new System.NotImplementedException();
        }
    }
}
