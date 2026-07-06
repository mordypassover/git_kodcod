using ex2.ImageMetadataManager__BAD;
using System;

namespace programRun
{
    class Program
    {

        public static void Main()
        {
            ImageMetadataManager imm1 = new ImageMetadataManager(1, 80, "EO");
            ImageMetadataManager imm2 = new ImageMetadataManager(2, 12.2, "IR");
            ImageMetadataManager imm6 = new ImageMetadataManager(3, 2.8, "SAR");
            Console.WriteLine($"{imm1.Format()}, {imm1.Score()}");
            Console.WriteLine($"{imm2.Format()}, {imm2.Score()}");
            Console.WriteLine($"{imm6.Format()}, {imm6.Score()}");
        }
    }
}