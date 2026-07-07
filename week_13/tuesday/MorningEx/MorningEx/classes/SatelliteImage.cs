using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.Satalite_Image
{
    abstract class SatelliteImage
    {
        public int Id;
        public double CloudCover;
        public int Value;

        public SatelliteImage(int id, double cloudcover, int value)
        {

            Id = id;
            CloudCover = cloudcover;
            Value = value;
            if (CloudCover < 0 || CloudCover > 100)
            {
                throw new ArgumentException("CloudCover must be 0 - 100");
            }


        }
        public override abstract string ToString();

        public virtual string Format()
        {
            return $"Image {Id} : {CloudCover}% cloud[{ToString()}]";
        }
        public virtual void SaveToFile(string path)
        => System.IO.File.AppendAllText(path, Format());
    }
}
