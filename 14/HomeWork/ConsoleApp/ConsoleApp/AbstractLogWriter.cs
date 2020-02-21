using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    enum logLevel { Info, Warning, Error };
    abstract class AbstractLogWriter : ILogWriter
    {
        public const string _logFormat = "{0:yyyy-MM-ddThh:mm:ss:ffff}\t{1}\t{2}";
        public void LogError(string message)
        {
            LogRecord(GetRecord(message, logLevel.Error));
        }

        public void LogInfo(string message)
        {
            LogRecord(GetRecord(message, logLevel.Info));
        }

        public void LogWarning(string message)
        {
            LogRecord(GetRecord(message, logLevel.Warning));
        }

        private string GetRecord(string message, logLevel level)
        {
            return string.Format(_logFormat, DateTime.Now, level, message);
        }

        abstract public void LogRecord(string message);

    }
}