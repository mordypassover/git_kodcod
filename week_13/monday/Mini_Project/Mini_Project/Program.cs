using ex2.Classes_refactord;
using Mini_Project.Satellite_Image;
using MiniProject.Satellite_Image;

namespace programRun
{
    class Program
    {

        public static void Main()
        {
            
            Repo<SatelliteImage> repo = new Repo<SatelliteImage>();
            repo.Add(new SarImage(10, 2.8));
            try
            {
                repo.Add(new QuickLookImage(33, -2.4));
            }
            catch (ArgumentException )
            {  }
            repo.GetAll();
        }
    }
}