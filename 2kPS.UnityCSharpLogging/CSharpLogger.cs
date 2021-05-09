using System;

namespace PS2k.UnityCSharpLogging {
    /// <summary>
    /// Contains logging functionality that uses the C# <see cref="System.Console">System.Console</see>.
    /// </summary>
    public class CSharpLogger : IUnityCSharpLogger {
        public void Log(object message) {
            if (!(message is string strMessage))
                strMessage = (message == null ? "" : message.ToString());
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Info");
            Console.ResetColor();
            Console.Write(": ");
            Console.WriteLine(strMessage);
        }

        public void LogWarning(object message) {
            if (!(message is string strMessage))
                strMessage = (message == null ? "" : message.ToString());
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Warning");
            Console.ResetColor();
            Console.Write(": ");
            Console.WriteLine(strMessage);
        }

        public void LogError(object message) {
            if (!(message is string strMessage))
                strMessage = (message == null ? "" : message.ToString());
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Error.Write("Error");
            Console.ResetColor();
            Console.Error.Write(": ");
            Console.Error.WriteLine(strMessage);
        }

        public void LogException(Exception exception) {
            string strMessage = (exception == null ? "" : exception.ToString());
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Error.Write("Exception");
            Console.ResetColor();
            Console.Error.Write(": ");
            Console.Error.WriteLine(strMessage);
        }
    }
}
