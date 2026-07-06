using System;
using System.Collections.Generic;
using System.Text;

namespace ex2.Classes_refactord
{
    class IR : BaseManeger
    {
        
        public IR(int id, double cloudcover) : base(id, cloudcover, 40) { }
        public override string ToString()
        {
            return "IR";
        }
        public override int CalcScore()
        {
            return Value - (int)CloudCover;
        }
    }
}
