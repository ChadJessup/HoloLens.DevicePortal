using HoloLens.DevicePortal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.HoloLens.DevicePortal.Api.App.PackageManager
{
    [TestClass]
    public class PackageManagerTests
    {
        private static class TestConstants
        {
        }

        [TestMethod]
        public void GetInstalledPackagesTest()
        {
            var pm = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).App.PackageManager.GetInstalledPackagesAsync().Result;
        }

        [TestMethod]
        public void GetInstallationStateTest()
        {
            string result = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).App.PackageManager.GetInstallationStateAsync().Result;

            Assert.IsTrue("No installation action was found".Equals(result));
        }
    }
}
