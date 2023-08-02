using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RadioBrowser.Utilities.JsonConverters
{
    internal class ArrayConverter : JsonConverter<string[]>
    {
        public override string[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.GetString()?.Split(',').Select(s => s.Trim()).ToArray();
        }

        public override void Write(Utf8JsonWriter writer, string[] value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
