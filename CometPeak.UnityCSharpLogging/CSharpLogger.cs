#if CSHARP_LOGGING
using System;

namespace CometPeak.UnityCSharpLogging {
    /// <summary>
    /// Contains logging functionality that uses the C# <see cref="System.Console">System.Console</see>.
    /// </summary>
    public class CSharpLogger : IUnityCSharpLogger {
        public void Log(object message) {
            if (!(message is string strMessage))
                strMessage = (message == null ? "" : message.ToString());
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            string prefix = string.Format("{0, -12}", "Info:");
            int spacesStart = "Info:".Length;
            Console.Write(prefix.Substring(0, spacesStart));
            Console.ResetColor();
            Console.Write(prefix.Substring(spacesStart, prefix.Length - spacesStart));

            Console.WriteLine(strMessage);
        }

        public void LogWarning(object message) {
            if (!(message is string strMessage))
                strMessage = (message == null ? "" : message.ToString());
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            string prefix = string.Format("{0, -12}", "Warning:");
            int spacesStart = "Warning:".Length;
            Console.Write(prefix.Substring(0, spacesStart));
            Console.ResetColor();
            Console.Write(prefix.Substring(spacesStart, prefix.Length - spacesStart));

            Console.WriteLine(strMessage);
        }

        public void LogError(object message) {
            if (!(message is string strMessage))
                strMessage = (message == null ? "" : message.ToString());
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            string prefix = string.Format("{0, -12}", "Error:");
            int spacesStart = "Error:".Length;
            Console.Error.Write(prefix.Substring(0, spacesStart));
            Console.ResetColor();
            Console.Error.Write(prefix.Substring(spacesStart, prefix.Length - spacesStart));

            Console.Error.WriteLine(strMessage);
        }

        public void LogException(Exception exception) {
            string strMessage = (exception == null ? "" : exception.ToString());
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            string prefix = string.Format("{0, -12}", "Exception:");
            int spacesStart = "Exception:".Length;
            Console.Error.Write(prefix.Substring(0, spacesStart));
            Console.ResetColor();
            Console.Error.Write(prefix.Substring(spacesStart, prefix.Length - spacesStart));

            Console.Error.WriteLine(strMessage);
        }
    }
}
#endif
