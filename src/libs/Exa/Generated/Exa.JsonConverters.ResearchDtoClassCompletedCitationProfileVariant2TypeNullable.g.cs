#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchDtoClassCompletedCitationProfileVariant2TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type?>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Exa.ResearchDtoClassCompletedCitationProfileVariant2TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.ResearchDtoClassCompletedCitationProfileVariant2TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
