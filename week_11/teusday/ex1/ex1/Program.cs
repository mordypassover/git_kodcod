using System;

namespace ClassEx
{
class ClassEx()
    {
     static void AddSignal(List<int[]> arrList)
        {
            int[] signal = new int[3];
            int userInput =0;
            bool flag = false;
            Console.WriteLine("enter signal id, classification and strength:");
            string userString;
            while (! flag)
            {
                userString = Console.ReadLine();
                flag = (int.TryParse(userString, out int num));
                userInput = num;
            }

            signal[0] = userInput;
            while (flag)
            {
                userString = Console.ReadLine();
                flag = (! int.TryParse(userString, out int num));
                if (! flag) userInput = num;
            }
            signal[1] = userInput;

            int? transmition = GetTransmitionStrength();
            if (transmition == null) { transmition = -1; }
            signal[2] = transmition.Value;



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
        }
        
     static void Main() 
        {
            List<int[]> tracks = new List<int[]>();
        }
    }
}


