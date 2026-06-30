#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksAttemptsListEventTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.WebhooksAttemptsListEventType?>
    {
        /// <inheritdoc />
        public override global::Exa.WebhooksAttemptsListEventType? Read(
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
                        return global::Exa.WebhooksAttemptsListEventTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.WebhooksAttemptsListEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.WebhooksAttemptsListEventType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.WebhooksAttemptsListEventType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.WebhooksAttemptsListEventTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
