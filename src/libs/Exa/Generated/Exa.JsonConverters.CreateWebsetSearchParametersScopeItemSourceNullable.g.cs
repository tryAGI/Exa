#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateWebsetSearchParametersScopeItemSourceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.CreateWebsetSearchParametersScopeItemSource?>
    {
        /// <inheritdoc />
        public override global::Exa.CreateWebsetSearchParametersScopeItemSource? Read(
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
                        return global::Exa.CreateWebsetSearchParametersScopeItemSourceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.CreateWebsetSearchParametersScopeItemSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.CreateWebsetSearchParametersScopeItemSource?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.CreateWebsetSearchParametersScopeItemSource? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Exa.CreateWebsetSearchParametersScopeItemSourceExtensions.ToValueString(value.Value));
            }
        }
    }
}
