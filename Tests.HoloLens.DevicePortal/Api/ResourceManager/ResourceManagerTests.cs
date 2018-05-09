using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.OS;
using Xunit;

namespace Tests.HoloLens.DevicePortal.Api.ResourceManager
{
    public class ResourceManagerTests
    {
        [Fact]
        public void GetActiveProcessesTest()
        {
            var activeProcesses = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).ResourceManager.GetActiveProcessesAsync().Result;
        }
    }
}
