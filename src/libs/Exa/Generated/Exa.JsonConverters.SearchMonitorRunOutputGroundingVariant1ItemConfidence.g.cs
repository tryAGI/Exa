#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchMonitorRunOutputGroundingVariant1ItemConfidenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence>
    {
        /// <inheritdoc />
        public override global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence Read(
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
                        return global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidenceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidenceExtensions.ToValueString(value));
        }
    }
}
