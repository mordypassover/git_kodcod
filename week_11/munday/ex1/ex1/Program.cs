using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Net.Http.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                if (!int.TryParse(sid, out int id)) continue;
                   
                string sspeed = Console.ReadLine();
                if(!int.TryParse(sspeed, out int speed)) continue;

                string sheading = Console.ReadLine();
                if(!int.TryParse(sheading, out int heading)) continue;

                userInput[0] = id;
                userInput[1] = speed;
                userInput[2] = heading;
                break;
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

        static void Main()
        {
            List<int> trackIdList = new List<int>();
            List<int> HeadingList = new List<int>();
            List<int> speedList = new List<int>();

            CreateTrack(trackIdList, HeadingList, speedList);
        }
    }
}