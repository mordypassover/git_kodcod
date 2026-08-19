using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preduser.Models;

internal class WeatherReading
{
    public string Location {  get; set; }
    public double TemperatureCelsius {  get; set; }
    public double Humidity {  get; set; }
    public DateTime Timestamp {  get; set; }
}
