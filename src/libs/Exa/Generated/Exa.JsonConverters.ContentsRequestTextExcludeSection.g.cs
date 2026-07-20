#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class ContentsRequestTextExcludeSectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ContentsRequestTextExcludeSection>
    {
        /// <inheritdoc />
        public override global::Exa.ContentsRequestTextExcludeSection Read(
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
                        return global::Exa.ContentsRequestTextExcludeSectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.ContentsRequestTextExcludeSection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.ContentsRequestTextExcludeSection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ContentsRequestTextExcludeSection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.ContentsRequestTextExcludeSectionExtensions.ToValueString(value));
        }
    }
}
