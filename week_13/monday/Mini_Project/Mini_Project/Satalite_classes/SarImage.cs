
using Mini_Project.Satalite_Image;
using MiniProject.Satellite_Image;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mini_Project.Satellite_Image
{
    class SarImage : SatelliteImage, IImageOps
    {
        public SarImage(int id, double cloudcover) : base(id, cloudcover, 100) { }
        public override string ToString()
        {
            return "SAR";
        }
        public override int CalcScore()
        {
            return Value - (int)CloudCover;
        }
        void Retask() { throw new InvalidOperationException("SarImage cant retask"); }
        void CalibrateThermal() { throw new InvalidOperationException("SarImage dosnt have thermul band"); }
    } 
}

