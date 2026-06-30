#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class ContentsRequestTextVariant1Verbosity2NullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ContentsRequestTextVariant1Verbosity2?>
    {
        /// <inheritdoc />
        public override global::Exa.ContentsRequestTextVariant1Verbosity2? Read(
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
                        return global::Exa.ContentsRequestTextVariant1Verbosity2Extensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.ContentsRequestTextVariant1Verbosity2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.ContentsRequestTextVariant1Verbosity2?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ContentsRequestTextVariant1Verbosity2? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.ContentsRequestTextVariant1Verbosity2Extensions.ToValueString(value.Value));
            }
        }
    }
}
