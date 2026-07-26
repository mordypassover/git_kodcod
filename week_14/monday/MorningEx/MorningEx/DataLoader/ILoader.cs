using MorningEx.Report;
using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.DataLoader
{
    internal interface ILoader
    {
        List<ReportClass> Load(string path);
    }
}
