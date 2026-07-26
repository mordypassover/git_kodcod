using MorningEx.DataLoader;
using MorningEx.Report;
using System;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MorningEx;

class Program
{
    public static void Main()
    {
        string fileName = "W4D2_reports.json";
        ILoader loader = new LoadJson();
        List<ReportClass> ReportList= loader.Load(fileName);

        Console.WriteLine(ReportList.Count);

        Console.WriteLine(string.Join(", ", ReportList
            .Where(report => report.Category == "SIGNAL")
            .Select(report => report.Id)));
        
        Console.WriteLine(string.Join(", ", ReportList
            .Where(report => report.Priority >=4)
            .Select(report => report.Id)));
        
        Console.WriteLine(string.Join(", ", ReportList
            .Where(report => report.Shift == "Night" && report.Zone == "North")
            .Select(report => report.Id)));

        List<int> id = ReportList
           .Where(report => report.Category == "COMMS")
           .Select(report => report.Id).ToList();
        List<int> priorety = ReportList
          .Where(report => report.Category == "COMMS")
          .Select(report => report.Priority).ToList();
        for (int i = 0; i < id.Count; i++)
        {
            Console.WriteLine($"id {id[i]}, priorety {priorety[i]}");
        }

        Console.WriteLine(string.Join(", ", ReportList
           .Where(report => report.SignalStrength >=  70 && report.SignalStrength <= 90)
           .Select(report => report.Id)));

        Console.WriteLine(string.Join(", ", ReportList
            .Where(report => report.Zone != "North")
            .Select(report => report.Id)));




        Console.WriteLine(string.Join(", ", ReportList
            .OrderByDescending(report => report.Priority)
            .Select(report => report.Id)));

        Console.WriteLine(string.Join(", ", ReportList
          .OrderByDescending(report => report.Zone)
          .Select(report => report.Id)));

        Console.WriteLine(string.Join(", ", ReportList
            .OrderByDescending(report => report.SignalStrength)
            .Select(report => report.Id).Take (3)));
    }

  
}

