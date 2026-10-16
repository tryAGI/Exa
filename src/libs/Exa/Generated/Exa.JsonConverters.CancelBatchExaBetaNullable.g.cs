#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class CancelBatchExaBetaNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.CancelBatchExaBeta?>
    {
        /// <inheritdoc />
        public override global::Exa.CancelBatchExaBeta? Read(
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
                        return global::Exa.CancelBatchExaBetaExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.CancelBatchExaBeta)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.CancelBatchExaBeta?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.CancelBatchExaBeta? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.CancelBatchExaBetaExtensions.ToValueString(value.Value));
            }
        }
    }
}
