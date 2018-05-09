
namespace HoloLens.DevicePortal.Converters
{
    using Api.Holographic.Perception.SurfaceReconstruction;
    using Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class SurfaceConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Surface);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartObject)
            {
                return null;
            }

            Surface surface = new Surface();

            JObject surfaceJson = JObject.Load(reader);

            surface.SurfaceId = surfaceJson["SurfaceId"].ToObject<Guid>();
            surface.VertexTransform = serializer.Deserialize<Matrix4x4>(surfaceJson["VertexTransform"].CreateReader());
            surface.NormalTransform = serializer.Deserialize<Matrix4x4>(surfaceJson["NormalTransform"].CreateReader());

            var normals = surfaceJson["Normals"];
            var indices = surfaceJson["Indices"];

            // surface.Normals.AddRange(this.GetVectorsFromLists(normals));

            surface.Vertices.AddRange(
                this.GetVectorsFromLists(surfaceJson["Vertices"],
                (x, y, z, w) =>
                {
                    var v = new Vector4(
                    x / 32767,
                    y / 32767,
                    z / 32767,
                    w / 32767);

                    return v;
                }));

            for (int c = 0; c < indices.Count() / 3 - 3; c++)
            {
                var indexedNormals = new List<Vector4>();

                for (int d = 0; d < 3; d++)
                {
                    int index = (int)indices[3 * c + d];

                    indexedNormals.Add(
                        new Vector4(
                        (float)normals["x"][index],
                        (float)normals["y"][index],
                        (float)normals["z"][index],
                        (float)normals["w"][index]));
                }

                surface.Faces.Add(new Face((int)indices[3 * c + 2], (int)indices[3 * c + 1], (int)indices[3 * c], indexedNormals));
            }

            return surface;
        }

        private IEnumerable<Vector4> GetVectorsFromLists(JToken jToken, Func<float, float, float, float, Vector4> adjustNumbers = null)
        {
            List<Vector4> vectors = new List<Vector4>();

            for (int i = 0; i < jToken["x"].Children().Count(); i++)
            {
                var x = (float)jToken["x"].Children().ElementAt(i);
                var y = (float)jToken["y"].Children().ElementAt(i);
                var z = (float)jToken["z"].Children().ElementAt(i);
                var w = (float)jToken["w"].Children().ElementAt(i);

                vectors.Add(
                    adjustNumbers == null
                    ? new Vector4(x, y, z, w)
                    : adjustNumbers(x, y, z, w));
            }

            return vectors;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
