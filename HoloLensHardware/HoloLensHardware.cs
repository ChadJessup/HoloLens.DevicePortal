namespace HoloLens.Hardware
{
    using Api.OS;
    using Api.Power;
    using System;

    // https://msdn.microsoft.com/en-us/windows/uwp/debug-test-perf/device-portal-api-core
    public class HoloLensHardware
    {
        public HoloLensHardware(string ip)
        {
            HoloLensHardware.HardwareAddress = new Uri(ip);
        }

        public static Uri HardwareAddress { get; set; }

        public OSSection OS { get; } = new OSSection();
        public PowerSection Power { get; set; } = new PowerSection();
    }
}
