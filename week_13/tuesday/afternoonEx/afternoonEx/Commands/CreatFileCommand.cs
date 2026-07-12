using System;
using System.Collections.Generic;
using System.Text;

namespace afternoonEx.Commands
{
    class CreatFileCommand : Command, IUndoubie 
    {
        string Name;

        public CreatFileCommand(string name, string content) : base(content)
        {
            Name = name;
            if (Name == "") 
            {
                throw new ArgumentException("no name fuond");
            }

        }
        public override bool execute()
        {
            if (!Name.StartsWith("_"))
            {
                Console.WriteLine($"file {Name} created");
                return true;
            }
            return false;

        }
        public void Undo()
        {
            Console.WriteLine($"undid file {Name} creation");
        }
    }
}
