using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace clicky_clicky.Surveys.Application.RequestModels
{
    public class TipRequest
    {
        [Required]
        public Point point { get; set; }
    }
}
