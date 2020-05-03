using System;
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


        public async Task CreateSurvey(Survey survey)
        {
            if (!survey.IsValid()) throw new ArgumentException();
            
            //await repository.Insert(survey);
            
            //save Image

            throw new System.NotImplementedException();
        }
    }
}
