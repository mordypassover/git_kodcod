using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MorningEx.classes
{
    internal class DiskStore : IStorer
    {
        private string _path;
        public DiskStore(string path) { _path = path; }

        public int CountData() => File.ReadAllLines(_path).Length;
        public void Save(SatelliteImage img)
        {
            File.AppendAllText(_path, "\n");
        }
        
    }
}
