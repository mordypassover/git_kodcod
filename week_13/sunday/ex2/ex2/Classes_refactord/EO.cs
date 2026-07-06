using System;
using System.Collections.Generic;
using System.Text;

namespace ex2.Classes_refactord
{
    class EO: BaseManeger

    {
        public EO(int id, double cloudcover ) : base(id, cloudcover, 80) { }
        public override string ToString()
        {
            return "EO";
        }
        public override int CalcScore()
        {
            return Value - (int)CloudCover;
        }
    }
}
