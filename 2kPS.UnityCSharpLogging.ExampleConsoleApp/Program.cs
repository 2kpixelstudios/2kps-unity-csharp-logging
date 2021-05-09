using System;

namespace PS2k.UnityCSharpLogging.ExampleConsoleApp {
    public class Program {
        public static void Main(string[] args) {
            UnityCSharpLogger.Log("This is information!");
            UnityCSharpLogger.LogWarning("This is a warning!");
            UnityCSharpLogger.LogError("This is an error!");
            UnityCSharpLogger.LogException(new Exception("Something went wrong (example)!"));
        }
    }
}
