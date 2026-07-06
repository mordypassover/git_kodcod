using System;
using System.Collections.Generic;
using System.Text;

namespace ex2.Classes_refactord
{
    class MULTISPECTRAL: BaseManeger, IScore
    {
        
        public MULTISPECTRAL(int id, double cloudcover) : base(id, cloudcover, 0) { }
        public override string ToString()
        {
            return "MULTISPECTRAL";
        }
        public override int CalcScore()
        {
            return Value - (int)CloudCover;
        }
    }
}
