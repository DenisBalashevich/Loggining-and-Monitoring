using System;
using NLog;

namespace MvcMusicStore.Logger
{
    public class Logger : ILogger
    {
        private readonly NLog.ILogger _logger = LogManager.GetLogger("MvcMusicStoreLogger");

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(string message, Exception ex)
        {
            _logger.Error(ex, message);
        }

        public void Error(string message, params object[] args)
        {
            _logger.Error(message, args);
        }

        public void Error(Exception ex)
        {
            _logger.Error(ex);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Info(string message, params object[] args)
        {
            _logger.Info(message, args);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Debug(string message, params object[] args)
        {
            _logger.Debug(message, args);
        }
    }
}
