using afternoonEx.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace afternoonEx
{
    class CommandParser
    {
        public Command Parse(string rawLine)
        {
            string[] line = rawLine.Split(' ');
            if (line.Length != 3) 
            {
                throw new CommandParseException($"line {rawLine} is not valid");
            }
            
            switch (line[0])
            {
                case "CREATE_FILE":
                    return new CreatFileCommand(line[1], line[2]);

                case "BACKUP":
                    return new BackupFileCommand(line[1], line[2]);

                case "SEND_EMAIL":
                    return new SendEmailCommand(line[1], line[2]);
                default:
                    throw new CommandParseException($"Command {line[0]} is not suported");
            }
        }
    }
    class CommandParseException: Exception
    {
        public string Messege;
        public CommandParseException(string essege) { Messege = essege; }
    }


}
