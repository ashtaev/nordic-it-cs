using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class MultipleLogWriter : ILogWriter
    {
        private static MultipleLogWriter instance;

        private MultipleLogWriter(ILogWriter[] arrayLogWriter) {
            this._arrayLogWriter = arrayLogWriter;
        }

        public static MultipleLogWriter GetInstance(ILogWriter[] arrayLogWriter)
        {
            if (instance == null) instance = new MultipleLogWriter(arrayLogWriter);
            return instance;
        }

        private ILogWriter[] _arrayLogWriter;

        public void LogError(string message)
        {
            foreach (ILogWriter logWriter in _arrayLogWriter) 
            logWriter.LogError(message);
        }

        public void LogInfo(string message)
        {
            foreach (ILogWriter logWriter in _arrayLogWriter)
            logWriter.LogInfo(message);
        }

        public void LogWarning(string message)
        {
            foreach (ILogWriter logWriter in _arrayLogWriter)
            logWriter.LogWarning(message);
        }
    }
}