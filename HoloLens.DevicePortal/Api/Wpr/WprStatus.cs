using System.Runtime.Serialization;

namespace HoloLens.DevicePortal.Api.Wpr
{
    // https://msdn.microsoft.com/en-us/windows/uwp/debug-test-perf/device-portal-api-core#windows-performance-recorder-wpr-
    public class WprStatus
    {
        // Documentation states that SessionType and StateType enums should be swapped from what we're
        // actually getting from the HoloLens... Fix this, if they fix that.
        public WprStateType SessionType { get; set; }
        public WprSessionType State { get; set; }
    }

    public enum WprStateType
    {
        None,

        [EnumMember(Value = "normal")]
        Normal,

        [EnumMember(Value = "boot")]
        Boot,
    }

    public enum WprSessionType
    {
        None,
        Running,
        Idle,
    }
}
