using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp
{
    class FileLogWriter : AbstractLogWriter, IDisposable
    {

        private static FileLogWriter instance;

        private FileLogWriter(string logFile = "logfile.bin")
        {
            _writer = new StreamWriter(File.Open(logFile, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read));
            _writer.BaseStream.Seek(0, SeekOrigin.End);
        }

        public static FileLogWriter GetInstance()
        {
            if (instance == null) instance = new FileLogWriter();
            return instance;
        }

        private StreamWriter _writer;

        public override void LogRecord(string message)
        {
            _writer.WriteLine(message);
            _writer.Flush();
        }

        public void Dispose()
        {
            if (_writer != null)
            {
                Console.WriteLine("FLW DISPOSE");
                _writer.Dispose();
            }
        }
    }
}