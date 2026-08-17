using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorMonitoring.Models;

public class SensorReading
{
    public string ReadingId {  get; set; }
    public decimal Temperature {  get; set; }
    public DateTime Timestamp {  get; set; }
}