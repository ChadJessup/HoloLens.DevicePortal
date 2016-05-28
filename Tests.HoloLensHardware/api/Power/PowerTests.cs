using HoloLens.Hardware.Api.Power;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HoloLens.Hardware.Tests.Api.Power
{
    [TestClass]
    public class PowerTests
    {
        private static class TestConstants
        {
        }

        [TestMethod]
        public void GetPowerStateTest()
        {
            PowerState power = new HoloLensHardware(TestHoloLens.Address).Power.GetPowerStateAsync().Result;

        }

        [TestMethod]
        public void GetBatteryTest()
        {
            Battery battery = new HoloLensHardware(TestHoloLens.Address).Power.GetBatteryAsync().Result;
        }
    }
}
