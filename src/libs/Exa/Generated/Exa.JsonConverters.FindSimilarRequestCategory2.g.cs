#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class FindSimilarRequestCategory2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.FindSimilarRequestCategory2>
    {
        /// <inheritdoc />
        public override global::Exa.FindSimilarRequestCategory2 Read(
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
                        return global::Exa.FindSimilarRequestCategory2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.FindSimilarRequestCategory2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.FindSimilarRequestCategory2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.FindSimilarRequestCategory2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.FindSimilarRequestCategory2Extensions.ToValueString(value));
        }
    }
}
