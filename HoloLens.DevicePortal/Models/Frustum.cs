using System.Numerics;

namespace HoloLens.DevicePortal.Models
{
    public class Frustum
    {
        public Vector4 Bottom { get; set; }
        public Vector4 Far { get; set; }
        public Vector4 Left { get; set; }
        public Vector4 Near { get; set; }
        public Vector4 Right { get; set; }
        public Vector4 Top { get; set; }
    }
}