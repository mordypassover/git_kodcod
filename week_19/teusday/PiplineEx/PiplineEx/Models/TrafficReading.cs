using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiplineEx.Models;

internal class TrafficReading
{
    public string Location {  get; set; }
    public int VehicleCount {  get; set; }
    public DateTime Timestamp { get; set; }
}