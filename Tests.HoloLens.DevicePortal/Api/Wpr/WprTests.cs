using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.Wpr;
using Xunit;

namespace Tests.HoloLens.DevicePortal.Api.Wpr
{
    public class WprTests
    {
        [Fact]
        public void GetStatusTests()
        {
            WprStatus status = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).Wpf.GetWprStatusAsync().Result;

            Assert.Equal(WprSessionType.Idle, status.State);
            Assert.Equal(WprStateType.Normal, status.SessionType);
        }
    }
}
