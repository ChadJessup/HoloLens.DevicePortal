
namespace HoloLens.DevicePortal.Converters
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Numerics;

    public class Vector4Converter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Vector4);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.StartArray)
            {
                return null;
            }

            var array = JArray.Load(reader);

            Vector4 vector = (Vector4)existingValue;

            vector.X = (float)array[0];
            vector.Y = (float)array[1];
            vector.Z = (float)array[2];
            vector.W = (float)array[3];

            return vector;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
