using HoloLens.DevicePortal.Models;
using System;

namespace HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction
{
    public class SurfaceReconstructedEventArgs : EventArgs
    {
        public SurfaceReconstructedEventArgs(Surface surface)
        {
            this.Surface = surface;
        }

        public Surface Surface { get; set; }
    }
}
