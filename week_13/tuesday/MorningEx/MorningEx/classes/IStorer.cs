using System;
using System.Collections.Generic;
using System.Text;


namespace MorningEx.classes
{
    interface IStorer
    {
        int CountData();
        void Save(SatelliteImage img);

    }
}
