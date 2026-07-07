using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.Satalite_Image
{
    class QuickLookImage:SatelliteImage
    {
        public QuickLookImage(int id, double cloudcover) : base(id, cloudcover, 0) { }
        public override string ToString() => "QuickLookImage";

    }
}
