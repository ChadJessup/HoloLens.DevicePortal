using HoloLens.DevicePortal;
using Xunit;

namespace Tests.HoloLens.DevicePortal.Api.App.PackageManager
{
    public class PackageManagerTests
    {
        [Fact]
        public void GetInstalledPackagesTest()
        {
            var pm = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).App.PackageManager.GetInstalledPackagesAsync().Result;
        }

        [Fact]
        public void GetInstallationStateTest()
        {
            string result = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).App.PackageManager.GetInstallationStateAsync().Result;

            Assert.Equal("No installation action was found", result);
        }
    }
}
