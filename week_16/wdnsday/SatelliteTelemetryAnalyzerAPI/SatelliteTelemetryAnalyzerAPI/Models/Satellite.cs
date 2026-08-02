using System.ComponentModel.DataAnnotations;

namespace SatelliteTelemetryAnalyzerAPI.Models
{
    public class Satellite
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(200, 40000)]
        public double OrbitAltitudeKm {  get; set; }

        [Required]
        [RegularExpression("^Active|Standby|Decommissioned$")]
        public string Status { get; set; } 
    }
}
