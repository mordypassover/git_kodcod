using System;
using System.Runtime.Intrinsics.X86;



namespace TrackReadout
{
    class Ex1
    {
        static void Main()
        {
            bool flag = true;

            while (flag)
            {


                //get input
                Console.WriteLine("enter track id");
                string userI1 = Console.ReadLine();
                if (!int.TryParse(userI1, out int trackId))
                {
                    Console.WriteLine("id not valid");
                    continue;
                }
                Console.WriteLine("enter speed");
                string userI2 = Console.ReadLine();
                if (!int.TryParse(userI2, out int speed))
                {
                    Console.WriteLine("speed not valid");
                    continue;
                }

                Console.WriteLine("enter heading");
                string userI3 = Console.ReadLine();
                if (!double.TryParse(userI3, out double heading) && 0 < heading && heading < 360)
                {
                    Console.WriteLine("heading not valid");
                    continue;
                }

                Console.WriteLine("enter status");
                string userI4 = Console.ReadLine();
                bool statusFlag = userI4 == "cruising" | userI4 == "turning" | userI4 == "stoped" | userI4 == "accelerating";
                if (!statusFlag)
                {
                    Console.WriteLine("status not valid");
                    continue;
                }

                //calc and print


                string speadCatigory;
                if (speed < 100) speadCatigory = "slow";
                else if (speed < 300) speadCatigory = "medium";
                else speadCatigory = "fast";

                double idGroup = (double)trackId / 10;
                double speedPerMinit = (double)speed / 60;

                Console.WriteLine(
                $"===Track Report===\n" +
                $"Track ID: {trackId}\n" +
                $"Speed: {speed} km/h ({speadCatigory})\n" +
                $"Heading: {heading} degrees\n" +
                $"Status: {userI4}\n" +
                $"Division Demo 1: trackId / 10 = {(int)idGroup} | {idGroup}\n" +
                $"Division Demo 2: speed / 60 = {(int)speedPerMinit} | {speedPerMinit}");
                flag = false;

            }
        }
    }
}
