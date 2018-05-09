using System.Numerics;

namespace HoloLens.DevicePortal.Models
{
    public class Display
    {
        public Frustum Frustum { get; set; }
        public Matrix4x4 Projection { get; set; }
        public Matrix4x4 View { get; set; }
    }
}