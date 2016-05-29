using HoloLens.DevicePortal.Api.Power;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HoloLens.DevicePortal.Tests.Api.Power
{
    [TestClass]
    public class PowerTests
    {
        [TestMethod]
        public void GetPowerStateTest()
        {
            PowerState power = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).Power.GetPowerStateAsync().Result;
        }

        [TestMethod]
        public void GetActiveConfigurationTest()
        {
            var content = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).Power.GetActivePowerSchemeIdAsync().Result;
        }

        [TestMethod]
        public void GetBatteryTest()
        {
            Battery battery = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).Power.GetBatteryAsync().Result;
        }
    }
}
