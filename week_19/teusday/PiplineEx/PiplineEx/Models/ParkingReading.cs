using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiplineEx.Models
{
    internal class ParkingReading
    {
        public string Location {  get; set; }
        public int AvailableSpots {  get; set; }
        public int TotalSpots {  get; set; }
        public DateTime Timestamp {  get; set; }
    }
}
