using MorningEx.classes;
using System;
using System.Runtime.InteropServices;

namespace MorningEx;

class Program
{
    public static void Main()
    {
        ImegePipline pipline = new ImegePipline(new DiskStore("disc.txt"));

        pipline.AddToStore
        (
            new List<SatelliteImage> 
            { 
                new SarImage(1, 33), 
                new SarImage(2, 55), 
                new QuickLookImage(3, 4) 
            }
        );
    }

}