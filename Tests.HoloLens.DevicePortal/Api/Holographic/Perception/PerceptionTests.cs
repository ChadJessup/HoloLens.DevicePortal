using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction;
using HoloLens.DevicePortal.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace Tests.HoloLens.DevicePortal.Api.Holographic.Perception
{
    [TestClass]
    public class PerceptionTests
    {
        private static class TestConstants
        {
        }

        [TestMethod]
        public void GetAllDetailsTest()
        {
            SurfaceReconstructionDetails deets = null;
            Surface surface = null;

            ManualResetEvent onLiveDetailsResetEvent = new ManualResetEvent(initialState: false);
            ManualResetEvent onSurfaceReceivedResetEvent = new ManualResetEvent(initialState: false);

            var sr = new HoloLensHardware(TestHoloLens.Address, TestHoloLens.Credentials).Holographic.Perception.StartSurfaceReconstruction().Result;

            sr.OnLiveDetailsReceived += (o, e) =>
            {
                deets = e.Details;
                onLiveDetailsResetEvent.Set();
            };

            sr.OnSurfaceReceived += (o, e) =>
            {
                surface = e.Surface;
                onSurfaceReceivedResetEvent.Set();
            };

            onLiveDetailsResetEvent.WaitOne(TimeSpan.FromSeconds(10.0));
            onSurfaceReceivedResetEvent.WaitOne(TimeSpan.FromSeconds(10.0));

            Assert.IsNotNull(deets);
            Assert.IsNotNull(surface);
        }
    }
}
