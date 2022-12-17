using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Log
{
    public class Logger
    {
        private Loggable LogType;

        public Logger(Loggable logType)
        {
            if (logType == null)
                throw new ArgumentNullException();
            LogType = logType;
        }

        public void Log<T>(T text)
        {
            LogType.Log(text);
        }

        public void Log<T>(LogErrorLevel errorLevel, T text)
        {
            LogType.Log(errorLevel, text);
        }

        public void Clear()
        {
            LogType.Clear();
        }

        public Loggable Type
        {
            get { return LogType; }
        }
    }
}
