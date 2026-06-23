using System;


namespace ex1
{
    class Ex1
    {
        static int[] GetUserInput()
        {
            int[] userInput = new int[3];
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("enter id, speed and heading: ");
                string sid = Console.ReadLine();
                if (!int.TryParse(sid, out int id))
                {
                    Console.WriteLine("id not valid"); 
                    continue;
                }
                string sheading = Console.ReadLine();
                if (! int.TryParse(sheading, out int heading) | heading > 360 | heading < 1)
                {
                    Console.WriteLine("heading not valid");
                    continue; 
                }
                string sspeed = Console.ReadLine();
                if (!int.TryParse(sspeed, out int speed) | speed < 0)
                {
                    Console.WriteLine("speed not valid");
                    continue;
                }
                userInput[0] = id;
                userInput[1] = heading;
                userInput[2] = speed;
                flag = false;
            }
            return userInput;
        }

        static void CreateTrack(List<int> idl, List<int> hl, List<int> sl)
        {
            int[] userImput = GetUserInput();
            idl.Add(userImput[0]);
            hl.Add(userImput[1]);
            sl.Add(userImput[2]);
        }
        static void Get(int id, List<int> idl, List<int> hl, List<int> sl)
        {
            for (int i = 0; i < idl.Count; i++)
            {
                if (idl[i] == id)
                {
                    Console.WriteLine($"id : {idl[i]} heading : {hl[i]} speed : {sl[i]}");
                    return;
                }
            }
            
            
        }

        static void RemoveTrack(int id, List<int> idl, List<int> hl, List<int> sl)
        {
            for (int i = 0; i < idl.Count; i++)
            {
                if (id == idl[i])
                {
                    idl.RemoveAt(i);
                    hl.RemoveAt(i);
                    sl.RemoveAt(i);
                    return;
                }
            }
            Console.WriteLine($"id {id} not found");
        }
        static void Get(List<int> idl, List<int> hl, List<int> sl)
        {
            for (int i =0; i<idl.Count; i++)
            {
                Console.WriteLine($"id : {idl[i]} heading : {hl[i]} speed : {sl[i]}");
            }
        }
        static void FilterSpeed(int speed, List<int> idl, List<int> hl, List<int> sl)
        {
            for (int i = 0; i < idl.Count; i++)
            {
                if (sl[i] > speed)
                {
                    Console.WriteLine($"id : {idl[i]} heading : {hl[i]} speed : {sl[i]}");
                }
            }
        }

        static void Summery(List<int> idl, List<int> hl, List<int> sl)
        {
            if (idl.Count == 0)
            {
                Console.WriteLine("No tracks in sistem");
                return;
            }
            int maxSpeedIndex = 0;
            int allSpeedSum = 0;
            for ( int i = 0; i < sl.Count; i++)
            {
                allSpeedSum = allSpeedSum + sl[i];
                if (sl[maxSpeedIndex] < sl[i])
                { 
                    maxSpeedIndex = i;
                }
                
            }
            Console.WriteLine($"fastist : {idl[maxSpeedIndex]}, avrege : {allSpeedSum/idl.Count}, count : {idl.Count}");
        }

        static int GetRuntimeInputs()
        {
            bool flag = true;
            int validInput = 0;
            while (flag)
            {
                string input = Console.ReadLine(); 
                if (int.TryParse(input,out int num))
                {
                    flag = false;
                    validInput = num;
                }
                else Console.Write("input not a number, try again: ");
            }
            return validInput;
        }
        static string Menu()
        {
            Console.WriteLine(
                "\n\n======== track manager ========\n\n" +
                "to creat track enter 1\n" +
                "to see all tracks enter 2\n" +
                "to see by id enter 3\n" +
                "to remove by id enter 4\n" +
                "to filter by speed enter 5\n" +
                "to get sumery enter 6\n" +
                "to exit enter 9\n");
                

            string userInput = Console.ReadLine();
            return userInput;
        }
        static void Main()
        {
            bool flag = true;
            List<int> trackIdList = new List<int>();
            List<int> HeadingList = new List<int>();
            List<int> speedList = new List<int>();
            while (flag)
            {
                string userImput = Menu();
                if (userImput == "1") CreateTrack(trackIdList, HeadingList, speedList);
                else if (userImput == "2") Get(trackIdList, HeadingList, speedList);
                else if (userImput == "3")
                {
                    Console.WriteLine("enter id: ");
                    int id = GetRuntimeInputs();
                    Get(id, trackIdList, HeadingList, speedList);
                }
                else if (userImput == "4")
                {
                    Console.WriteLine("enter id: ");
                    int id = GetRuntimeInputs();
                    RemoveTrack(id, trackIdList, HeadingList, speedList);
                }
                else if (userImput == "5")
                {
                    Console.WriteLine("enter speed: ");
                    int speed = GetRuntimeInputs();
                    FilterSpeed(speed, trackIdList, HeadingList, speedList);
                }
                else if (userImput == "6")
                {
                    Summery(trackIdList, HeadingList, speedList);
                }
                else if (userImput == "9") flag = false;

                else Console.WriteLine("input not valid");
            }
        }
    }
}