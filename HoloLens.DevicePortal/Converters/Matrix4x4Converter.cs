
namespace HoloLens.DevicePortal.Converters
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Numerics;

    public class Matrix4x4Converter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Matrix4x4);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray)
            {
                return null;
            }

            var array = JArray.Load(reader);

            var matrix =
                new Matrix4x4(
                (float)array[0], (float)array[4], (float)array[8], (float)array[12],
                (float)array[1], (float)array[5], (float)array[9], (float)array[13],
                (float)array[2], (float)array[6], (float)array[10], (float)array[14],
                (float)array[3], (float)array[7], (float)array[11], (float)array[15]);

            return matrix;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
