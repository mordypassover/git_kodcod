using System;

namespace testExamps
{
    class Track
    {
        public int Id { get; }
        public double Speed { get; set; }
        public Track(int id, double speed)
        {
            Id = id;
            Speed = speed;
            Console.WriteLine($"hello from Track constructer");
        }
    }
    class Aircraft : Track 
    {
        public double Altitude { get; }
        public Aircraft(int id, double speed, double altitude): base(id, speed) 
        {
            Altitude = altitude;
            Console.WriteLine("hello from Aircraft class");
        }
    }
    class MainClass
    {
        static void Main()
        {
            Aircraft a = new Aircraft(1, 420, 30000);
            Console.WriteLine($"{a.Id} {a.Speed} {a.Altitude}");
        }
    }
}