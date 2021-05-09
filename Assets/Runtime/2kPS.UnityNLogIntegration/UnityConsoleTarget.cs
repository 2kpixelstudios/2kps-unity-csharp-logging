using System;
using System.Collections.Generic;
using System.IO;
using NLog;
using NLog.Targets;
using UnityEngine;

namespace PS2k.UnityNLogIntegration {
    //See NLog documentation on creating a custom Target:
    //https://github.com/NLog/NLog/wiki/How-to-write-a-custom-target

    //See NLog dcumentation on registering custom Target here:
    //https://github.com/NLog/NLog/wiki/Register-your-custom-component
    [Target(nameof(UnityConsoleTarget), IsWrapper = true)]
    public class UnityConsoleTarget : Target {
        private struct LogLevelInfo {
            public LogLevel logLevel;
            public Action<string> logFunction;
        }
        private static readonly Lazy<Dictionary<int, LogLevelInfo>> LogLookup = new Lazy<Dictionary<int, LogLevelInfo>>(
            () => {
                return new Dictionary<int, LogLevelInfo>() {
                    { LogLevel.Trace.Ordinal,
                        new LogLevelInfo() {
                            logLevel = LogLevel.Trace,
                            logFunction = Debug.Log
                        }
                    },
                    { LogLevel.Debug.Ordinal,
                        new LogLevelInfo() {
                            logLevel = LogLevel.Debug,
                            logFunction = Debug.Log
                        }
                    },
                    { LogLevel.Info.Ordinal,
                        new LogLevelInfo() {
                            logLevel = LogLevel.Info,
                            logFunction = Debug.Log
                        }
                    },
                    { LogLevel.Warn.Ordinal,
                        new LogLevelInfo() {
                            logLevel = LogLevel.Warn,
                            logFunction = Debug.LogWarning
                        }
                    },
                    { LogLevel.Error.Ordinal,
                        new LogLevelInfo() {
                            logLevel = LogLevel.Error,
                            logFunction = Debug.LogError
                        }
                    },
                    { LogLevel.Fatal.Ordinal,
                        new LogLevelInfo() {
                            logLevel = LogLevel.Fatal,
                            logFunction = Debug.LogError
                        }
                    },
                };
            }
        );

        protected override void Write(LogEventInfo logEvent) {
            string message = logEvent.FormattedMessage;

            LogLookup.Value[logEvent.Level.Ordinal].logFunction(message);

            Exception e = logEvent.Exception;
            if (e != null)
                Debug.LogException(e);
        }
    }
}
