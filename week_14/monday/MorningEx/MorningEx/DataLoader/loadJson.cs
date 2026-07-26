using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using MorningEx.Report;

namespace MorningEx.DataLoader
{
    class LoadJson:ILoader
    {
        public List<ReportClass> Load(string path)
        {
            string data = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<ReportClass>>(data);
        }
        
    }
}
