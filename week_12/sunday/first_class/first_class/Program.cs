using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace class_examples
{
    public class Track1
    {
        public int Id;
        public double Speed;

        public Track1(int id, double speed)
        {
            Id = id;
            Speed = speed;
            Console.WriteLine("constructer ran");
        }
    }

    public class Track2
    {
        public int Id;
        public Track2(int id) { Id = id; }
    }
    public class Track3
    {
        public int Id;
        public double Speed;
        public double Heading;

        public Track3(int id, double speed, double heading)
        {
            Id = id;
            Speed = speed;
            Heading = heading;
        }
        public Track3(int id) : this(id, 0.0, 0.0) { }
    }
    public class Track4
    {
        private double _heading; 
        public int Id { get; } 
        public double Speed { get; set; }
        public double Heading
        {
            get => _heading;
            set
            {
                if (value < 0 || value > 359)
                    _heading = 0; 
                else
                    _heading = value;
            }
        }
        public Track4(int id, double speed, double heading)
        {
            Id = id;
            Speed = speed;
            Heading = heading;
        }
        public override string ToString() 
            => $"Track {Id}: {Speed} kn, heading {Heading}";
    }

    static class run_nain
    {
        static void Main() 
        {
            Track1 a = new Track1(17, 412.5);
            Track1 b = new Track1(5, 66.4);
            Console.WriteLine($"{a.Id}, {b.Id}, ");

            Track2 c = new Track2(4);
            Console.WriteLine($"{c.Id} ");

            Track3 d = new Track3(3, 33.6, 320);
            Track3 e = new Track3(9);
            Console.WriteLine($"{d.Id}, {d.Speed}");
            Console.WriteLine($"{e.Id}, {e.Speed}");

            Track4 f = new Track4(17, 412.5, 270);
            Console.WriteLine(f); 
            f.Heading = 999;
            Console.WriteLine(f.Heading);
        }
    }
}
