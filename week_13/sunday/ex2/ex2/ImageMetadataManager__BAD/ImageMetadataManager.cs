using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ex2.ImageMetadataManager__BAD;

class ImageMetadataManager
{
    public int Id;
    public double CloudCover;
    public string Sensor;

    public ImageMetadataManager(int id, double cloudcover, string sensor)
    {
        Id = id;
        CloudCover = cloudcover;
        Sensor = sensor;
    }
    public bool IsValid()
    {
        return (CloudCover >= 0 && CloudCover <= 100);
    }
    public string Format()
    {
        return $"Image {Id} : {CloudCover}% cloud[{Sensor}]";
    }
    public void SaveToFile(string path) 
        => System.IO.File.AppendAllText(path, Format());

    public int Score()
    {
        switch (Sensor)
        {
            case ("SAR"): return 100 - (int)CloudCover;

            case ("EO"): return 60 - (int)CloudCover;

            case ("IR"): return 40 - (int)CloudCover;
            
            default: return 0;

        }
    }
}

