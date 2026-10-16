#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class ContentsOptionsTextVariant1VerbosityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ContentsOptionsTextVariant1Verbosity?>
    {
        /// <inheritdoc />
        public override global::Exa.ContentsOptionsTextVariant1Verbosity? Read(
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
                        return global::Exa.ContentsOptionsTextVariant1VerbosityExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.ContentsOptionsTextVariant1Verbosity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.ContentsOptionsTextVariant1Verbosity?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ContentsOptionsTextVariant1Verbosity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.ContentsOptionsTextVariant1VerbosityExtensions.ToValueString(value.Value));
            }
        }
    }
}
