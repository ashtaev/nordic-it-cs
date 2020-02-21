using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class ConsoleLogWriter : AbstractLogWriter
    {
        private static ConsoleLogWriter instance;

        private ConsoleLogWriter() { }

        public static ConsoleLogWriter GetInstance()
        {
            if (instance == null) instance = new ConsoleLogWriter();
            return instance;
        }

        public override void LogRecord(string message)
        {
            Console.WriteLine(message);
        }
    }
}