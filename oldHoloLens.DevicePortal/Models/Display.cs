namespace HoloLens.DevicePortal.Models
{
    using System.Numerics;

    public class Display
    {
        public Frustum Frustum { get; set; }
        public Matrix4x4 Projection { get; set; }
        public Matrix4x4 View { get; set; }
    }
}