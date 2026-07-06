using ex2.Classes_refactord;
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

            Repo<BaseManeger> repo = new Repo<BaseManeger>();
            repo.Add(new SAR(10, 2.8));
            repo.Add(new IR(11, 3.2));
            try
            {
                repo.Add(new SAR(33, -2.4)); 
            } 
            catch (ArgumentException ex)
            { Console.WriteLine(ex.Message); }
            
            repo.Add(new SAR(12, 22.3));
            repo.GetAll();

        }
    }
}