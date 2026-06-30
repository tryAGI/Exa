#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchEventDtoClassVariant3TaskOutputEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchEventDtoClassVariant3TaskOutputEventType?>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchEventDtoClassVariant3TaskOutputEventType? Read(
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
                        return global::Exa.ResearchEventDtoClassVariant3TaskOutputEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.ResearchEventDtoClassVariant3TaskOutputEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.ResearchEventDtoClassVariant3TaskOutputEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchEventDtoClassVariant3TaskOutputEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.ResearchEventDtoClassVariant3TaskOutputEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
