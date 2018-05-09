
namespace HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction
{
    using Models;
    using System.Numerics;

    public class SurfaceReconstructionDetails
    {
        public TrackingState TrackingState { get; set; }
        public Camera Camera { get; set; }
        public LSRPlane LSRPlane { get; set; }
        public Matrix4x4 HeadToAttachedFor { get; set; }
        public Matrix4x4 OriginToAttachedFor { get; set; }
    }
}
