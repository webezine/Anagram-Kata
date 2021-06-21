using System;
using Microsoft.Extensions.Logging;
using AnagramConsole.Common.Interfaces;
using NLog;

namespace AnagramConsole.Common.Adapters
{
    public class LoggerAdapter<T> : ILoggerAdapter<T>
    {
        private readonly ILogger<T> _logger;

        public LoggerAdapter(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void Error(Exception ex, string message, params object[] args)
        {
            _logger.LogError(ex, message, args);
        }

        public void Information(string message)
        {
            _logger.LogInformation(message);
        }

        public void Debug(string message, params object[] args)
        {
            _logger.LogDebug(message, args);
        }

        public void Trace(string message, int userId)
        {
            MappedDiagnosticsLogicalContext.Set("UserId", userId);
            _logger.LogTrace(message);
        }

        public void Warning(string message)
        {
            _logger.LogWarning(message);
        }

    }
}
