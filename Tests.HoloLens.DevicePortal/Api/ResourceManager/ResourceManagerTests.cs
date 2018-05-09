using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.OS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.HoloLens.DevicePortal.Api.ResourceManager
{
    [TestClass]
    public class ResourceManagerTests
    {
        [TestMethod]
        public void GetActiveProcessesTest()
        {
            var activeProcesses = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).ResourceManager.GetActiveProcessesAsync().Result;
        }
    }
}
