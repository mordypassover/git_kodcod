using System;
using System.Collections.Generic;
using System.Text;

namespace afternoonEx.Commands
{
    class BackupFileCommand : Command, IUndoubie, IRedouble
    {
        string Name;

        public BackupFileCommand(string name, string content) : base(content)
        {
            Name = name;
            if (Name == "")
            {
                throw new ArgumentException("no name fuond");
            }
        }
        public override bool execute()
        {
            
            Console.WriteLine($"file {Name} Backed up");
            return true;
        }
        public void Undo()
        {
            Console.WriteLine($"undid file {Name} backup");
        }
        public void Redo()
        {
            Console.WriteLine($"retrying to backup file {Name}");
        }
    }
}
