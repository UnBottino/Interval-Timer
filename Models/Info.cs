using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Interval_Timer.Models
{
    public class Info
    {
        [DisplayName("Round Time (Mins)")]
        [Required(ErrorMessage = "A Round Time is required!")]
        public int? RoundTime { get; set; }

        [DisplayName("Rest Time (Mins)")]
        [Required(ErrorMessage = "A Rest Time is required!")]
        public int? RestTime { get; set; }

        [DisplayName("Round Count")]
        [Required(ErrorMessage = "A Round Count is required!")]
        public int? RoundCount { get; set; }
    }
}