using afternoonEx.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace afternoonEx.loggers
{
    class FileCommandLogger : ICommandLogger
    {
        public string FileName;
        public FileCommandLogger(string filePath) { FileName = filePath; }
            

        public void LogResult(Command command, bool success);
            

    }
}
