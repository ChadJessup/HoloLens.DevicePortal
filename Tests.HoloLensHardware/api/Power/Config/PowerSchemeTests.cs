using HoloLens.DevicePortal.Api.Power.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HoloLens.DevicePortal.Tests.Api.Power.Config
{
    [TestClass]
    public class PowerSchemeTests
    {
        [TestMethod]
        public void GetCurrentPowerSchemeTest()
        {
            PowerScheme powerScheme = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).Power.Config.GetCurrentSchemeAsync().Result;
        }
    }
}
