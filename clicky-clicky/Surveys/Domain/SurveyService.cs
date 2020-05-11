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


        public async Task CreateSurvey(Survey survey, IFormFile image)
        {
            if (!survey.IsValid()) throw new ArgumentException();

            //using var stream = new FileStream(filename, FileMode.Create);
            //await surveyRequest.File.CopyToAsync(stream);
            
            //await repository.Insert(survey);
            
            //save Image

            throw new System.NotImplementedException();
        }
    }
}
