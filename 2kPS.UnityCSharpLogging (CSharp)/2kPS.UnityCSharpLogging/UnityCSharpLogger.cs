using System;

namespace PS2k.UnityCSharpLogging {
    public class UnityCSharpLogger {
        private static Lazy<UnityCSharpLogger> globalLogger = new Lazy<UnityCSharpLogger>(
            () => new UnityCSharpLogger()
        );
    }
}
