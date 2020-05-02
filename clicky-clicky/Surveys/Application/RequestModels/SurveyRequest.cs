using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace clicky_clicky.Surveys.Application.RequestModels
{
    public class SurveyRequest
    {
        [Required]
        public string Question { get; set; }

        [Required]
        public IFormFile Image { get; set; }

        [Required]
        public bool ShowResolutionAfterTip { get; set; }
    }
}
