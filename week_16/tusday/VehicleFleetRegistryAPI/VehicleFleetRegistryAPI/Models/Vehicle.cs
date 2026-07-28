using System.ComponentModel.DataAnnotations;

namespace VehicleFleetRegistryAPI.Models
{
    public class Vehicle
    {
        public int Id;

        [Required]
        [Length(5, 15)]
        public string RegistrationNumber { get; set; }


        [Required]
        [StringLength(50)]
        public string VehicleType { get; set; }

        [Required]
        [RegularExpression("^Available|In-Use|Maintenance|Decommissioned$")]
        public string Status { get; set; }

        [StringLength(100)]
        public string? AssignedDriver { get; set; }

        [StringLength(200)]
        public string? CurrentLocation { get; set; }

        [Required]
        [Range(0, 500000)]
        public int Mileage { get; set; }
    }
}
