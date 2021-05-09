using System;
using UnityEngine;

namespace PS2k.UnityCSharpLogging {
    /// <summary>
    /// Contains logging functionality that uses <see cref="UnityEngine"/>'s <see cref="Debug.Log(object)">Debug.LogXXX(...)</see> methods.
    /// </summary>
    public class UnityLogger : IUnityCSharpLogger {
        public void Log(object message) {
            Debug.Log(message);
        }

        public void LogWarning(object message) {
            Debug.LogWarning(message);
        }

        public void LogError(object message) {
            Debug.LogError(message);
        }

        public void LogException(Exception exception) {
            Debug.LogException(exception);
        }
    }
}
