using System;
using System.Collections.Generic;
using System.Text;

namespace ex2.Classes_refactord
{
    class SAR: BaseManeger
    {
        public SAR(int id, double cloudcover) : base(id, cloudcover, 100) { }
        public override string ToString()
        {
            return "SAR";
        }
        public override int CalcScore()
        {
            return Value - (int)CloudCover;
        }
    }
}
