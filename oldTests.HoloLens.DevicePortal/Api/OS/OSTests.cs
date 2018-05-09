using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.OS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.HoloLens.DevicePortal.Api.OS
{
    [TestClass]
    public class OSTests
    {
        private static class TestConstants
        {
            public const string ComputerName = "HoloOfScience";
            public const string OsVersion = "11082.1033.x86fre.rs1_release_hl.160201-1452";
        }

        [TestMethod]
        public void GetInfoTest()
        {
            Info info = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).OS.GetInfoAsync().Result;

            Assert.AreEqual(TestConstants.ComputerName, info.ComputerName);
            Assert.AreEqual("en-us", info.Language);
            Assert.AreEqual("WindowsHolographic", info.OsEdition);
            Assert.AreEqual(TestConstants.OsVersion, info.OsVersion);
            Assert.AreEqual("HoloLens", info.Platform);
        }

        [TestMethod]
        public void GetMachineNameTest()
        {
            string machineName = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).OS.GetMachineNameAsync().Result;

            Assert.AreEqual(TestConstants.ComputerName, machineName);
        }
    }
}
