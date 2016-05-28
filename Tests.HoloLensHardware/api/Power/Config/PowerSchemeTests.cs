using HoloLens.Hardware.Api.Power;
using HoloLens.Hardware.Api.Power.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HoloLens.Hardware.Tests.Api.Power.Config
{
    [TestClass]
    public class PowerSchemeTests
    {
        private static class TestConstants
        {
        }

        [TestMethod]
        public void GetCurrentPowerSchemeTest()
        {
            PowerScheme powerScheme = new HoloLensHardware(TestHoloLens.Address).Power.Config.GetCurrentSchemeAsync().Result;
        }
    }
}
