using System;

namespace AnagramConsole.Common.Interfaces
{
    public interface ILoggerAdapter<T>
    {
        void Trace(string message, int userId);
        void Debug(string message, params object[] args);
        void Information(string message);
        void Warning(string message);
        void Error(Exception ex, string message, params object[] args);
    }
}
