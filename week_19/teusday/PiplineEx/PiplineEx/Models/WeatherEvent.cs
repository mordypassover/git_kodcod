using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiplineEx.Models
{
    public class WeatherEvent
    {
        public int Id { get; set; }
        public string Location { get; set; } = string.Empty;
        public double TemperatureCelsius { get; set; }
        public double Humidity { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime ProcessedAt { get; set; }
    }
}
