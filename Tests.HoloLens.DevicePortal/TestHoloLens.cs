

namespace Tests.HoloLens.DevicePortal
{
    using System.Net;

    public static class TestHoloLens
    {
        public const string Address = "http://192.168.1.134";
        public const string TestUsername = "test";
        public const string TestPassword = "1234567";
        public static readonly NetworkCredential Credentials = new NetworkCredential(TestHoloLens.TestUsername, TestHoloLens.TestPassword);
    }
}
