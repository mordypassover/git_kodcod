using System;
using System.Collections.Generic;
using System.Text;

namespace MorningEx.Readers
{
    class ReadFile:IReader
    {

        public string GetData(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("cant read file, it is not found.");
            }

            return File.ReadAllText(path);
        }
    }
}
