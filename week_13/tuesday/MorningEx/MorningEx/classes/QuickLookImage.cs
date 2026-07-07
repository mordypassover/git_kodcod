using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.classes;
    class QuickLookImage:SatelliteImage
    {
        public QuickLookImage(int id, double cloudcover) : base(id, cloudcover, 0) { }
        public override string ToString() => "QuickLookImage";

    }

