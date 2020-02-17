using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        public override void LogRecord(string message)
        {
            Console.WriteLine(message);
        }
    }
}