#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebsetSearchRecallExpectedConfidenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.WebsetSearchRecallExpectedConfidence>
    {
        /// <inheritdoc />
        public override global::Exa.WebsetSearchRecallExpectedConfidence Read(
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
                        return global::Exa.WebsetSearchRecallExpectedConfidenceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.WebsetSearchRecallExpectedConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.WebsetSearchRecallExpectedConfidence);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.WebsetSearchRecallExpectedConfidence value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.WebsetSearchRecallExpectedConfidenceExtensions.ToValueString(value));
        }
    }
}
