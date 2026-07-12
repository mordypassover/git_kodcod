using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.Readers
{
    interface IReader
    {
        string GetData(string path);
    }
}
