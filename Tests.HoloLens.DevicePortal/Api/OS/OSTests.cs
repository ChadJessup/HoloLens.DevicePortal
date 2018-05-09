using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.OS;
using Xunit;

namespace Tests.HoloLens.DevicePortal.Api.OS
{
    public class OSTests
    {
        private static class TestConstants
        {
            public const string ComputerName = "HoloOfScience";
            public const string OsVersion = "14393.2189.x86fre.rs1_release.180329-1711";
        }

        [Fact]
        public void GetInfoTest()
        {
            Info info = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).OS.GetInfoAsync().Result;

            Assert.Equal(TestConstants.ComputerName, info.ComputerName);
            Assert.Equal("en-us", info.Language);
            Assert.Equal("WindowsHolographic", info.OsEdition);
            Assert.Equal(TestConstants.OsVersion, info.OsVersion);
            Assert.Equal("HoloLens", info.Platform);
        }

        [Fact]
        public void GetMachineNameTest()
        {
            string machineName = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).OS.GetMachineNameAsync().Result;

            Assert.Equal(TestConstants.ComputerName, machineName);
        }
    }
}
