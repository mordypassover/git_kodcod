using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EtlPreduser.Models
{
    public class Analyst
    {
        public int analyst_id {  get; set; }
        public string name {  get; set; }
        public string arena {  get; set; }
        public string specialty {  get; set; }
    }
}
