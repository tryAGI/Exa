#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchPublicationEntityOutputPropertiesTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.SearchPublicationEntityOutputPropertiesType>
    {
        /// <inheritdoc />
        public override global::Exa.SearchPublicationEntityOutputPropertiesType Read(
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
                        return global::Exa.SearchPublicationEntityOutputPropertiesTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.SearchPublicationEntityOutputPropertiesType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.SearchPublicationEntityOutputPropertiesType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.SearchPublicationEntityOutputPropertiesType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.SearchPublicationEntityOutputPropertiesTypeExtensions.ToValueString(value));
        }
    }
}
