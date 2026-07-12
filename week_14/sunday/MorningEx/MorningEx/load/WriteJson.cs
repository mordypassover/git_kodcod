using MorningEx.validation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json; 

namespace MorningEx.load
{
    class WriteJson
    {
        public void SaveData(List<Report> dataReports)
        {

            JsonSerializerOptions opts = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(dataReports, opts);

            File.WriteAllText("reports.json", json);
        }
    }
}
