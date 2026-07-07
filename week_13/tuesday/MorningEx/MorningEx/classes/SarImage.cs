
using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.classes;
    class SarImage : SatelliteImage, Iscorabul
    {
        public SarImage(int id, double cloudcover) : base(id, cloudcover, 100) { }
        public override string ToString()
        {
            return "SAR";
        }
        public int CalcScore()
        {
            return Value = Value - (int)CloudCover;
        }
    } 


