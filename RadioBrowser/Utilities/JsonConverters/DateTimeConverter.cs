using System;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RadioBrowser.Utilities.JsonConverters
{
    internal class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            DateTime result;
            string a = reader.GetString();

            if (!DateTime.TryParse(reader.GetString(), out result))
            {
                Trace.WriteLine("Cannot parse date.");
                result = default;
            }

            return result;
            /*
            try
            {
                return DateTime.ParseExact(reader.GetString()!, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture);
            }
            catch (FormatException)
            {
                Trace.WriteLine("Cannot parse date.");
                return new DateTime(0);
            }*/
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
