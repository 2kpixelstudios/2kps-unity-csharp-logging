using NLog;
using NLog.Targets;
using UnityEngine;

namespace PS2k.UnityNLogIntegration {
    //See NLog documentation on creating a custom Target:
    //https://github.com/NLog/NLog/wiki/How-to-write-a-custom-target

    //See NLog dcumentation on registering custom Target here:
    //https://github.com/NLog/NLog/wiki/Register-your-custom-component
    [Target(nameof(UnityConsoleTarget), IsWrapper = true)]
    public class UnityConsoleTarget : TargetWithLayout {
        protected override void Write(LogEventInfo logEvent) {
            string message = Layout.Render(logEvent);
            Debug.Log(message);
        }
    }
}
