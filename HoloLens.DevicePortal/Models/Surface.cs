
namespace HoloLens.DevicePortal.Models
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Surface
    {
        public Guid SurfaceId { get; set; }

        // public List<Vector4> Normals { get; } = new List<Vector4>();
        public List<Vector4> Vertices { get; } = new List<Vector4>();
        public List<Face> Faces { get; } = new List<Face>();

        public Matrix4x4 NormalTransform { get; set; }
        public Matrix4x4 VertexTransform { get; set; }
    }
}