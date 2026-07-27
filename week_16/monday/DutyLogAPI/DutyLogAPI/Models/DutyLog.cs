using System.ComponentModel.DataAnnotations;

namespace DutyLogAPI.Models
{
    public class DutyLog
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "DutyLog must get a name!")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "DutyLog must get a Station name!")]
        [StringLength(100)]
        public string Station { get; set; } = string.Empty;

        [Required(ErrorMessage = "DutyLog must get shift start time!")]
        public DateTime ShiftStart { get; set; }

        [Required(ErrorMessage = "DutyLog must get shift end time")]
        public DateTime ShiftEnd { get; set; }
        public string Remarks { get; set; } = string.Empty;
    }
}
