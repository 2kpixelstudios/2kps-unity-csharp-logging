using System;
using System.Collections.Generic;
using System.Text;

namespace CometPeak.UnityCSharpLogging {
    /// <summary>
    /// Represents a combination of one or more loggers.
    /// </summary>
    internal class CompoundLogger : IUnityCSharpLogger {
        private List<IUnityCSharpLogger> loggers = new List<IUnityCSharpLogger>();

        public bool Add(IUnityCSharpLogger logger) {
            if (logger == null || loggers.Contains(logger))
                return false;
            loggers.Add(logger);
            return true;
        }

        public void Log(object message) {
            foreach (IUnityCSharpLogger logger in loggers)
                logger.Log(message);
        }

        public void LogWarning(object message) {
            foreach (IUnityCSharpLogger logger in loggers)
                logger.LogWarning(message);
        }

        public void LogError(object message) {
            foreach (IUnityCSharpLogger logger in loggers)
                logger.LogError(message);
        }

        public void LogException(Exception exception) {
            foreach (IUnityCSharpLogger logger in loggers)
                logger.LogException(exception);
        }
    }
}
