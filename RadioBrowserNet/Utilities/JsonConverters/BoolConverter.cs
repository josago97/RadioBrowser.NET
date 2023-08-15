using System.Text.Json.Serialization;
using System.Text.Json;
using System;

namespace RadioBrowserNet.Utilities.JsonConverters
{
    internal class BoolConverter : JsonConverter<bool>
    {
        public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            short number = reader.GetInt16();
            return number == 1;
        }

        public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
