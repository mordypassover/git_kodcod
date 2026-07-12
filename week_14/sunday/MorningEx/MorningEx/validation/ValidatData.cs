using System;
using System.Collections.Generic;
using System.Text;
using MorningEx.exceoptions;

namespace MorningEx.validation
{
    class ValidatData
    {
        public List<Report> validate(string data)
        {
            List<Report> validated = new List<Report>();
            int cnt = 0;
            int regected = 0;
            foreach (string line in data.Split('\n'))
            {
                try
                {
                    string[] splitLine = line.Split(' ');
                    if (splitLine.Length != 3)
                    {
                        regected++;
                        throw new FormatException($"Expected 3 parts, but got {splitLine.Length}.");
                    }

                    if (!int.TryParse(splitLine[2], out int calssification) || !int.TryParse(splitLine[0], out int id))
                    {
                        regected++;
                        throw new FormatException($"cant parse, {splitLine[2]} is not valid.");
                    }
                    if (calssification <= 0)
                    {
                        regected++;
                        throw new NegitiveClasificationException("can't have negitive classifiction");
                    }
                    cnt++;
                    validated.Add(new Report(id, splitLine[1], calssification));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NegitiveClasificationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            Console.WriteLine($"added {cnt}, regected {regected}");

            return validated;
        }

    }
}
