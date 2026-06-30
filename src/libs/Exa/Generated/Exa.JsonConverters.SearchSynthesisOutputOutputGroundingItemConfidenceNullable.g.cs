#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchSynthesisOutputOutputGroundingItemConfidenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence?>
    {
        /// <inheritdoc />
        public override global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence? Read(
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
                        return global::Exa.SearchSynthesisOutputOutputGroundingItemConfidenceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.SearchSynthesisOutputOutputGroundingItemConfidenceExtensions.ToValueString(value.Value));
            }
        }
    }
}
