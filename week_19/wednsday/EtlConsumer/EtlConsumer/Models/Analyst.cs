using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EtlConsumer.Models
{
    public class Analyst
    {
        
        public int analyst_id {  get; set; }
        public string name {  get; set; }
        public string arena {  get; set; }
        public string specialty {  get; set; }
        public ICollection<Call> Calls { get; set; } = new List<Call>();
    }
}
