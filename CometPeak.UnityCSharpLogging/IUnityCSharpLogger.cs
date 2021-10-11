using System;

namespace CometPeak.UnityCSharpLogging {
    /// <summary>
    /// Represents a logging system that can work either in Unity or C# .NET environments.
    /// </summary>
    public interface IUnityCSharpLogger {
        void Log(object message);
        void LogWarning(object message);
        void LogError(object message);
        void LogException(Exception exception);
    }
}
