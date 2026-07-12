using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.exceoptions
{
    class NegitiveClasificationException:Exception
    {
        public NegitiveClasificationException(string messege):base(messege) { }
        public NegitiveClasificationException(string messege, Exception origin):base(messege, origin) { }
    }
}
