#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateImportParametersVariant1FormatNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.CreateImportParametersVariant1Format?>
    {
        /// <inheritdoc />
        public override global::Exa.CreateImportParametersVariant1Format? Read(
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
                        return global::Exa.CreateImportParametersVariant1FormatExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.CreateImportParametersVariant1Format)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.CreateImportParametersVariant1Format?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.CreateImportParametersVariant1Format? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.CreateImportParametersVariant1FormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
