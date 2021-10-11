using System;

namespace CometPeak.UnityCSharpLogging {
    /// <summary>
    /// Contains global logging functions to share across a codebase.
    /// </summary>
    public class UnityCSharpLogger {
        private static readonly Lazy<IUnityCSharpLogger> GlobalLogger
            = new Lazy<IUnityCSharpLogger>(CreateLogger, true);

        private static IUnityCSharpLogger CreateLogger() {
            CompoundLogger loggers = new CompoundLogger();
#if UNITY_LOGGING
            loggers.Add(new UnityLogger());
#endif
#if CSHARP_LOGGING
            loggers.Add(new CSharpLogger());
#endif
            return loggers;
        }

        public static void Log(object message) => GlobalLogger.Value.Log(message);
        public static void LogWarning(object message) => GlobalLogger.Value.LogWarning(message);
        public static void LogError(object message) => GlobalLogger.Value.LogError(message);
        public static void LogException(Exception exception) => GlobalLogger.Value.LogException(exception);
    }
}
