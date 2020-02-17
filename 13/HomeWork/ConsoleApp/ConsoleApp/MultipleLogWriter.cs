using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class MultipleLogWriter : ILogWriter
    {
        private ILogWriter[] _arrayLogWriter;

        public MultipleLogWriter(ILogWriter[] arrayLogWriter)
        {
            this._arrayLogWriter = arrayLogWriter;
        }

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