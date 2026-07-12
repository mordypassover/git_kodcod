using afternoonEx.loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace afternoonEx
{
    class BatchRunner‏
    {
        private readonly ICommandLogger _logger;
        private readonly CommandParser _parser;
        private int _succeeded;
        private int _failed;
        private int _unparseable;
        public BatchRunner(ICommandLogger logger) 
        { 
            _logger = logger;
            _parser = new CommandParser();
        }

        public void Run(List<string> rawLines) { }

        public RunSummary GetSummary() { }



    }
}
