using MorningEx.load;
using MorningEx.Readers;
using MorningEx.validation;
using System;

namespace MorningEx;

class Program
{
    public static void Main()
    {

        string fileName = "w4d1_field_reports_input.txt";
        IReader reader = new ReadFile();
        ValidatData validator = new ValidatData();
        WriteJson writeJson = new WriteJson();
        try
        {
            writeJson.SaveData(validator.validate(reader.GetData(fileName)));
        }
         
        catch(FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine(File.ReadAllText("reports.json"));
    }
    
}