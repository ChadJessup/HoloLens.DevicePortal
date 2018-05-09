using HoloLens.DevicePortal;
using HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction;
using HoloLens.DevicePortal.Models;
using System;
using System.Threading;
using Xunit;

namespace Tests.HoloLens.DevicePortal.Api.Holographic.Perception
{
    public class PerceptionTests
    {
        [Fact]
        public void GetAllDetailsTest()
        {
            SurfaceReconstructionDetails deets = null;
            Surface surface = null;

            ManualResetEvent onLiveDetailsResetEvent = new ManualResetEvent(initialState: false);
            ManualResetEvent onSurfaceReceivedResetEvent = new ManualResetEvent(initialState: false);

            var sr = new HoloLensHardware(TestFixture.Context.Address, TestFixture.Context.Credentials).Holographic.Perception.StartSurfaceReconstruction().Result;

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

            Assert.NotNull(deets);
            Assert.NotNull(surface);
        }
    }
}
