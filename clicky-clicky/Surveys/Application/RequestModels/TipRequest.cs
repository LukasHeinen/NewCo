using System.ComponentModel.DataAnnotations;
using clicky_clicky.Surveys.Models;

namespace clicky_clicky.Surveys.Application.RequestModels
{
    public class TipRequest
    {
        [Required]
        public Point point { get; set; }
    }
}
