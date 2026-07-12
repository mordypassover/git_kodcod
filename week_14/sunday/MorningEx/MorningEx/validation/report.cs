using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.validation
{
    class Report
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }

        public Report(int id, string category, int priority)
        {
            ID = id;
            Category = category;
            Priority = priority;
        }
    }

}
