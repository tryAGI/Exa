#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchResponseOutputGroundingItemConfidenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.SearchResponseOutputGroundingItemConfidence>
    {
        /// <inheritdoc />
        public override global::Exa.SearchResponseOutputGroundingItemConfidence Read(
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
                        return global::Exa.SearchResponseOutputGroundingItemConfidenceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.SearchResponseOutputGroundingItemConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.SearchResponseOutputGroundingItemConfidence);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.SearchResponseOutputGroundingItemConfidence value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.SearchResponseOutputGroundingItemConfidenceExtensions.ToValueString(value));
        }
    }
}
