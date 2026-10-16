#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchCompanyEntityOutputPropertiesResearchNotableWorkTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType?>
    {
        /// <inheritdoc />
        public override global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType? Read(
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
                        return global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.SearchCompanyEntityOutputPropertiesResearchNotableWorkTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
