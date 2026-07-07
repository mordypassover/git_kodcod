
using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.classes
{
    class MemoryStore:IStorer
    {
        public List<SatelliteImage> Data = new List<SatelliteImage>();


        public int CountData() => Data.Count;

        public void Save(SatelliteImage img)
        {
            Data.Add(img);
           
        }
    }
}
