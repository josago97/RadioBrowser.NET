using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RadioBrowserNet.Utilities.JsonConverters
{
    internal class UriConverter : JsonConverter<Uri>
    {
        public override Uri Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            Uri result = null;
            string url = reader.GetString();

            if (!string.IsNullOrEmpty(url) || url == "null")
            {
                url = url.Replace(',', '.').Replace("..", ".");

                try
                {
                    result = new Uri(url);
                }
                catch
                {
                    Trace.WriteLine("Cannot parse URI.");
                }
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, Uri value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
