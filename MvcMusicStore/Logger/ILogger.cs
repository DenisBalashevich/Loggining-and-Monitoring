using System;

namespace MvcMusicStore.Logger
{
    public interface ILogger
    {
        void Error(string message);
        void Error(string message, Exception ex);
        void Error(string message, params object[] args);
        void Error(Exception ex);

        void Info(string message);
        void Info(string message, params object[] args);

        void Debug(string message);
        void Debug(string message, params object[] args);
    }
}
