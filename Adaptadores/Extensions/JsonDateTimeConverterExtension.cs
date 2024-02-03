using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Adaptadores.Extensions
{
    [ExcludeFromCodeCoverage]
    public class JsonDateTimeConverterExtension : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String && DateTime.TryParseExact(reader.GetString(), "yyyy-MM-dd HH:mm:ss", null, System.Globalization.DateTimeStyles.None, out var date))
                return date;

            throw new JsonException($"Cannot parse datetime in format yyyy-MM-dd HH:mm:ss");
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
