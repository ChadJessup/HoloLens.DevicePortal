using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.Power.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.HoloLens.DevicePortal.Api.Power.Config
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
