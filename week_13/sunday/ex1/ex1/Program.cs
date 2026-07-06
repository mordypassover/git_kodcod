//// BAD — one class, four reasons to change
//using System.ComponentModel.DataAnnotations;
//using System.Xml;
//namespace ex1
//{
//    class TrackAll
//    {
//        public int Id;
//        public double Speed;
//        public bool IsValid() => Speed >= 0; //validation reason

//        public string Format() => $"Track {Id}: {Speed} kn"; //formatting reason

//        public void SaveToFile(string path) //storage reason
//            => System.IO.File.WriteAllText(path, Format());
//    }
//    // Change the file format and you edit the same class that holds the data.

//    // GOOD — one reason to change each
//    class Track // 1) holds and guards its own data

//    {
//        public int Id { get; }
//        public double Speed { get; }
//        public Track(int id, double speed)
//        {
//        if (speed < 0) throw new ArgumentException("speed cannot be negative");
//        Id = id; Speed = speed;
//        }
//        public override string ToString() => $"Track {Id}: {Speed} kn";
//    }
//    class TrackFormatter
//    {
//        public string ToCsv(Track t) => $"{t.Id},{t.Speed}";
//    } // 2) formatting
//    class FileTrackStore
//    // 3) storage
//    {
//        public void Save(Track t, string path) =>
//        System.IO.File.WriteAllText(path, t.ToString());
//    }
//    class Program 
//    {
//        public static void Main()
//        {
//            TrackAll t1 = new TrackAll();

//        }
//    }
//}

// GOOD — add a kind by adding a class; this code never changes


// ex2

//abstract class Track
//{
//    public double Speed { get; init; }
//    public abstract int Score();

//}
//class Aircraft : Track { public override int Score() => (int)(Speed * 2); }


//class Vessel : Track { public override int Score() => (int)(Speed * 1); }
//// New kind = new class. ThreatScorer never changes when you add GroundVehicle.

//class ThreatScorer { public int Score(Track t) => t.Score(); } //polymorphism dispatches
