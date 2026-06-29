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
        }
    }
    class Aircraft : Track 
    {
        public double Altitude { get; }
        public Aircraft(int id, double speed, double altitude): base(id, speed) 
        {
            Altitude = altitude; 
        }
    }
}