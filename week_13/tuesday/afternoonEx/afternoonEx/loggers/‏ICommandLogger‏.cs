using afternoonEx.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace afternoonEx.loggers
{
    interface ICommandLogger
    {
        void LogResult(Command command, bool success);
    }
}
