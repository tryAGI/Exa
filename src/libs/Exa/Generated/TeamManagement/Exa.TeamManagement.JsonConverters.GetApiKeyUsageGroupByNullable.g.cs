#nullable enable

namespace Exa.TeamManagement.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetApiKeyUsageGroupByNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.TeamManagement.GetApiKeyUsageGroupBy?>
    {
        /// <inheritdoc />
        public override global::Exa.TeamManagement.GetApiKeyUsageGroupBy? Read(
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
                        return global::Exa.TeamManagement.GetApiKeyUsageGroupByExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.TeamManagement.GetApiKeyUsageGroupBy)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.TeamManagement.GetApiKeyUsageGroupBy?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.TeamManagement.GetApiKeyUsageGroupBy? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.TeamManagement.GetApiKeyUsageGroupByExtensions.ToValueString(value.Value));
            }
        }
    }
}
