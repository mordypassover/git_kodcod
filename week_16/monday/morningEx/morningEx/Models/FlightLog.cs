using System.ComponentModel.DataAnnotations;

namespace morningEx.Models
{
    public class FlightLog
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Flight num Required!")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Flightnum must be 3-10 characters!")]
        public string FlightNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Airline is required!")]
        [StringLength(50, ErrorMessage = "airline name cant be more then 50 chars!")]
        public string Airline { get; set; } = string.Empty;

        [Required(ErrorMessage = "Destination is required")]
        [StringLength(100, ErrorMessage = "Destination cannot exceed 100 chars")]
        public string Destination { get; set; } = string.Empty;

        [Range(1, 1000, ErrorMessage = "Passenger count must be between 1 and 1000")]
        public int PassengerCount { get; set; }

        [Required(ErrorMessage = "Departure time is required")]
        public DateTime ScheduledDeparture { get; set; }

        public DateTime? ActualDeparture { get; set; }

        [StringLength(500, ErrorMessage = "Remarks cannot exceed 500 chars")]
        public string? Remarks { get; set; }

        public string Status { get; set; } = "Scheduled";
    }
}
