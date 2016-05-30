
namespace HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction
{
    using Models;
    using System;

    public class SurfaceReconstructedEventArgs : EventArgs
    {
        public SurfaceReconstructedEventArgs(Surface surface)
        {
            this.Surface = surface;
        }

        public Surface Surface { get; set; }
    }
}
