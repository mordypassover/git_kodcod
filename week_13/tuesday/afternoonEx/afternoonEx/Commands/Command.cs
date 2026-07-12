using System;
using System.Collections.Generic;
using System.Text;

namespace afternoonEx.Commands
{
    abstract class Command
    {
        public string Content;

        public Command(string content)
        {
            Content = content;
        }
        public abstract bool execute();
    }
    
}
