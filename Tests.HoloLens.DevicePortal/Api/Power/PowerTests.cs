using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.Power;
using Xunit;

namespace Tests.HoloLens.DevicePortal.Api.Power
{
    public class PowerTests
    {
        [Fact]
        public void GetPowerStateTest()
        {
            PowerState power = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).Power.GetPowerStateAsync().Result;
        }

        [Fact]
        public void GetActiveConfigurationTest()
        {
            var content = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).Power.GetActivePowerSchemeIdAsync().Result;
        }

        [Fact]
        public void GetBatteryTest()
        {
            Battery battery = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).Power.GetBatteryAsync().Result;
        }
    }
}
