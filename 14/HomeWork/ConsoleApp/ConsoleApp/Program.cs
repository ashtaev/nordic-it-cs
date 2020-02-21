using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            FileLogWriter fileLogWriter = FileLogWriter.GetInstance();
            ConsoleLogWriter consoleLogWriter = ConsoleLogWriter.GetInstance();

            ILogWriter[] arrayLogWriter = new ILogWriter[2] { fileLogWriter, consoleLogWriter };

            MultipleLogWriter multipleLogWriter = MultipleLogWriter.GetInstance(arrayLogWriter);
            multipleLogWriter.LogInfo("Message info");
            multipleLogWriter.LogWarning("Message warning");
            multipleLogWriter.LogError("Message error");

            MultipleLogWriter multipleLogWriter2 = MultipleLogWriter.GetInstance(arrayLogWriter);
            FileLogWriter fileLogWriter2 = FileLogWriter.GetInstance();
            ConsoleLogWriter consoleLogWriter2 = ConsoleLogWriter.GetInstance();

            Console.WriteLine(multipleLogWriter2.Equals(multipleLogWriter));
            Console.WriteLine(fileLogWriter2.Equals(fileLogWriter));
            Console.WriteLine(consoleLogWriter2.Equals(consoleLogWriter));

            Console.ReadKey();
        }
    }
}