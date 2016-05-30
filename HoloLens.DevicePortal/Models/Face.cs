namespace HoloLens.DevicePortal.Models
{
    using System.Collections.Generic;
    using System.Numerics;

    public class Face
    {
        public Face(int v1idx, int v2idx, int v3idx, IEnumerable<Vector4> vertices)
        {
            this.Vertex1Index = v1idx;
            this.Vertex2Index = v2idx;
            this.Vertex3Index = v3idx;

            this.Normals = vertices;
        }

        public int Vertex1Index { get; set; }
        public int Vertex2Index { get; set; }
        public int Vertex3Index { get; set; }

        public IEnumerable<Vector4> Normals { get; set; }
    }
}
