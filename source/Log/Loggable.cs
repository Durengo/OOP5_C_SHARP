using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5.source.Log
{
    public enum LogErrorLevel
    {
        TRACE = 0,
        INFO = 1,
        WARN = 2,
        ERROR = 3,
        FATAL = 4
    }

    public interface Loggable
    {
        void Log<T>(T text);
        void Log<T>(LogErrorLevel errorLevel, T text);
        void Clear();
    }
}
