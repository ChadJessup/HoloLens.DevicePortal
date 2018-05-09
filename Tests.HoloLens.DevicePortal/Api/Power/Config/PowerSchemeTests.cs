using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.Power.Config;
using Xunit;

namespace Tests.HoloLens.DevicePortal.Api.Power.Config
{
    public class PowerSchemeTests
    {
        [Fact]
        public void GetCurrentPowerSchemeTest()
        {
            PowerScheme powerScheme = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).Power.Config.GetCurrentSchemeAsync().Result;
        }
    }
}
