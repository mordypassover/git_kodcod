using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DronesConsumer.Models
{
    public class Unit
    {
        [Key]
        public int unit_id { get; set; }
        public int model_id { get; set; }
        public string operator_name {  get; set; }
        public DateTime first_seen_date {  get; set; }
        public string status {  get; set; }
        public double home_lat {  get; set; }
        public double home_lon {  get; set; }
        public UavModel? UavModel {  get; set; }

        public ICollection<Track> Tracks { get; set; } = new List<Track>(); 

    }
}
