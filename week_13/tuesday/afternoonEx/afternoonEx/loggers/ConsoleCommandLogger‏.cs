using afternoonEx.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace afternoonEx.loggers
{
    class ConsoleCommandLogger : ICommandLogger
    {
        public void LogResult(Command command, bool success);
            

    }
}
