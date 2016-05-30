
namespace HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction
{
    using System;

    public class SurfaceReconstructionDetailsEventArgs : EventArgs
    {
        public SurfaceReconstructionDetailsEventArgs(SurfaceReconstructionDetails details)
        {
            this.Details = details;
        }

        public SurfaceReconstructionDetails Details { get; set; }
    }
}