using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace clicky_clicky.Surveys.Application.RequestModels
{
    public class SurveyRequest
    {
        [Required]
        public string Question { get; set; }

        [Required]
        public IFormFile Image { get; set; }
    }
}
