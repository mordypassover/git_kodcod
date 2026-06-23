using System;
using System.Data;
using System.Diagnostics;

namespace ClassEx
{
    public enum signalStatus
    {
        Friendly,
        Hostile,
        Unidentified
    }
    class ClassEx()
    {
        static void AddSignal(List<int?[]> arrList)
        {
            int?[] signal = new int?[3];
            int userInput =0;
            bool flag = false;

            Console.WriteLine("enter signal id, classification and strength:");
            string userString;
            // geting signal id
            while (! flag)
            {
                userString = Console.ReadLine();
                flag = (int.TryParse(userString, out int num));
                userInput = num;
            }

            signal[0] = userInput;

            // geting signal classification
            while (flag)
            {
                Console.WriteLine("classifications:\n" +
                    "Friendly: 1\nHostile: 2\nUnidentified: 3");
                userString = Console.ReadLine();
                flag = (!(int.TryParse(userString, out int num) && num > 0 && num < 4));
                userInput = num;
            }
            signal[1] = userInput;

            int? transmition = GetTransmitionStrength();
            signal[2] = transmition.Value;

            arrList.Add(signal);
        }
        static int? GetTransmitionStrength()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            if (int.TryParse(input, out int parsedNumber))
            {
                return parsedNumber;
            }
            Console.WriteLine("input not valid, giving null");

            return null;
        }
        static void ShowAllTransmitions(List<int?[]> arrList)
        {
            
            string status;

            foreach (int?[] i in arrList)
            {
                status = ((signalStatus)i[1]).ToString();
                Console.WriteLine($"signal id : {i[0]}, status : {status}, strength : {i[2]}");
            }
        }
        static void UpdateStatus(List<int?[]> arrList)
        {
            int? id =null;
            bool flag = true;
            string userInput;
            int? strength=null;
            while (flag)
                {
                Console.WriteLine("enter id to update:");
                userInput = Console.ReadLine();
                flag = int.TryParse(userInput, out int num);
                id = num;
                }
            while (!flag)
            {
                Console.WriteLine("enter strength:");
                userInput = Console.ReadLine();
                flag = int.TryParse(userInput, out int num);
                strength = num;
            }
            foreach (int?[] i in arrList)
                {
                    if (i[0] == id)
                    {
                    i[2] = strength;
                    }
                

                } 
         
        }
        static void Menu()
        {
            Console.WriteLine(@"
===== signel logger =====
to creat log enter 1
to see all loggs enter 2
to update signal enter 3
to exit enter 4
                ");
        }
        static void Main() 
        {
            List<int?[]> tracks = new List<int?[]>();
            bool flag = true;
            string userC;
            while (flag)
            {
                Menu();
                userC = Console.ReadLine();
                switch (userC)
                {
                    case "1":
                        AddSignal(tracks);continue;
                    case "2":
                        ShowAllTransmitions(tracks); continue;
                    case "3":
                        UpdateStatus(tracks);
                        continue;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("bad input");
                        continue;
                }
            }
        }
    }
}


