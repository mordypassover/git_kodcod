using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtlConsumer.Models
{
    public class Call
    {
        public int call_id {  get; set; }
        public int analyst_id {  get; set; }
        public int agent_id {  get; set; }
        public int word_bravo {  get; set; }
        public int word_charlie {  get; set; }
        public Analyst? Analyst { get; set; }
    }
}
