using System;

namespace tracker
{
    abstract class Platform
    {
        private int _trackId;
        private double _speedKnots;
        private double _heading;

        public int TrackId { get => _trackId; }
        public double SpeedKnots
        {
            get => _speedKnots;
            set
            {
                if (value < 0) { _speedKnots = 0; }
                else { _speedKnots = value; }
            }
        }
        public double Heading
        {
            get => _heading;
            set
            {
                if (!(0 <= value && value < 360))
                { _heading = 0; }
                else { _heading = value; }
            }
        }

        public Platform(int trackId, double speedKnots, double heading) 
        {
            _trackId = trackId;
            SpeedKnots = speedKnots;
            Heading = heading;
        }

        abstract public string StatusLine();
        abstract public bool IsTrackable();

        override public string ToString()
        {
            return $"TrackId: {TrackId} | Speed: {SpeedKnots} kn | Heading: {Heading}";
        }
    }
    class AirPlatform : Platform
    {
        private double _altitudeFeet;

        public double AltitudeFeet 
        {
            get => _altitudeFeet ;
            set
            {
                if (value < 0) _altitudeFeet = 0;
                else _altitudeFeet = value;
            }
        }

        public AirPlatform(int trackId, double speedKnots, double heading,double altitudeFeet)
            : base(trackId, speedKnots, heading) 
        {
            AltitudeFeet = altitudeFeet;
        }
        override public string StatusLine()
        {
            return $"Platform Id: {TrackId} | type: AirPlatform | Speed: {SpeedKnots} kn | Heading: {Heading} | Altitude: {AltitudeFeet} feet";
        }
        override public bool IsTrackable()
        {
            return (SpeedKnots > 0 && AltitudeFeet > 100 && AltitudeFeet < 60000);
        }
    }
    class SeaPlatform : Platform
    {
        private double _depthMeters;

        public double DepthMeters
        {
            get => _depthMeters;
            set
            {
                if (value > 0) _depthMeters = 0;
                else _depthMeters = value;
            }
        }

        public SeaPlatform(int trackId, double speedKnots, double heading, double depthMeters)
            : base(trackId, speedKnots, heading)
        {
            DepthMeters = depthMeters;
        }
        override public string StatusLine()
        {
            return $"Platform Id: {TrackId} | type: SeaPlatform | Speed: {SpeedKnots} kn | Heading: {Heading} | Depth: {DepthMeters} feet";
        }
        override public bool IsTrackable()
        {
            return ( DepthMeters > -300);
        }
    }
    class GroundPlatform : Platform
    {
        private string _terrainType;

        public string TerrainType{ get ; set;}

        public GroundPlatform(int trackId, double speedKnots, double heading, string terrainType)
            : base(trackId, speedKnots, heading)
        {
            TerrainType = terrainType;
        }
        override public string StatusLine()
        {
            return $"Platform Id: {TrackId} | type: GroundPlatform | Speed: {SpeedKnots} kn | Heading: {Heading} | TerrainType: {TerrainType}";
        }
        override public bool IsTrackable()
        {
            return (TerrainType != "tunnel");
        }
    }
    class MainRun
    {
        static void Main()
        {
            List<Platform> platformList = new List<Platform>();
            platformList.Add(new SeaPlatform(1, 4.0, 224.8, -367));
            platformList.Add(new AirPlatform(22, 180.7, 33.8, 85));
            platformList.Add(new SeaPlatform(4, 44, 3, -87));
            platformList.Add(new GroundPlatform(77, 80.5, 28, "tunnel"));
            platformList.Add(new GroundPlatform(999, 46, 100.8, "flat"));
            platformList.Add(new AirPlatform(2, 400.7, 19.48, 900));

            foreach (Platform platform in platformList) { Console.WriteLine($"{platform.StatusLine()} , Trackable = {platform.IsTrackable()}");  }
        }
    }
}