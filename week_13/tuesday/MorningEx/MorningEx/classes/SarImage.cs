
using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.Satalite_Image;
    class SarImage : SatelliteImage, Iscorabul
    {
        public SarImage(int id, double cloudcover) : base(id, cloudcover, 100) { }
        public override string ToString()
        {
            return "SAR";
        }
        public int CalcScore()
        {
            return Value - (int)CloudCover;
        }
        void Retask() { throw new InvalidOperationException("SarImage cant retask"); }
        void CalibrateThermal() { throw new InvalidOperationException("SarImage dosnt have thermul band"); }
    } 
}

