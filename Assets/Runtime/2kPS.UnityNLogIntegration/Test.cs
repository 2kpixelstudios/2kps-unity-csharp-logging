using System;
using NLog;
using NLog.Config;
using NLog.Targets;
using UnityEngine;

using Logger = NLog.Logger;
using ILogger = NLog.ILogger;

namespace PS2k.UnityNLogIntegration {
    public class Test : MonoBehaviour {
        private void Start() {
            LoggingConfiguration config = new LoggingConfiguration();

            UnityConsoleTarget consoleTarget = new UnityConsoleTarget();
            config.AddRule(LogLevel.Trace, LogLevel.Fatal, consoleTarget);
            LogManager.Configuration = config;

            Logger logger = config.LogFactory.GetLogger(GetType().FullName);
            logger.Log(LogLevel.Info, "Omg!?");
            logger.Log(LogLevel.Warn, "Omg!?");
            logger.Log(LogLevel.Error, "Omg!?");
            logger.Log(LogLevel.Info, new Exception("LOL"), "HI!");
        }
    }
}
