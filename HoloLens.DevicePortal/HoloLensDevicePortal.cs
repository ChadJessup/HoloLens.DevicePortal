using HoloLens.DevicePortal.Api.App;
using HoloLens.DevicePortal.Api.Holographic;
using HoloLens.DevicePortal.Api.OS;
using HoloLens.DevicePortal.Api.Power;
using HoloLens.DevicePortal.Api.ResourceManager;
using HoloLens.DevicePortal.Api.Wpr;
using System;
using System.Net;

namespace HoloLens.DevicePortal
{
    // https://msdn.microsoft.com/en-us/windows/uwp/debug-test-perf/device-portal-api-core
    public class HoloLensHardware
    {
        public HoloLensHardware(string ip, NetworkCredential credentials)
        {
            HoloLensHardware.HardwareAddress = new Uri(ip);
            HoloLensHardware.Credentials = credentials;
        }

        public HoloLensHardware(string ip, string username, string password)
            : this(ip, new NetworkCredential(username, password))
        {
        }

        public static Uri HardwareAddress { get; set; }
        public static NetworkCredential Credentials { get; set; }

        public OSSection OS { get; } = new OSSection();
        public PowerSection Power { get; } = new PowerSection();
        public WindowsPerformanceRecorderSection Wpf { get; } = new WindowsPerformanceRecorderSection();
        public AppSection App { get; } = new AppSection();
        public ResourceManagerSection ResourceManager { get; } = new ResourceManagerSection();
        public HolographicSection Holographic { get; } = new HolographicSection();
    }
}
