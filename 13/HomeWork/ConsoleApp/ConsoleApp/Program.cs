using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            var fileLogWriter = new FileLogWriter();
            var consoleLogWriter = new ConsoleLogWriter();

            ILogWriter[] arrayLogWriter = new ILogWriter[2] { fileLogWriter, consoleLogWriter };

            var multipleLogWriter = new MultipleLogWriter(arrayLogWriter);
            multipleLogWriter.LogInfo("Message info");
            multipleLogWriter.LogWarning("Message warning");
            multipleLogWriter.LogError("Message error");

            Console.ReadKey();
        }
    }
}