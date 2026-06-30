#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateWebsetParametersExcludeItemSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.CreateWebsetParametersExcludeItemSource>
    {
        /// <inheritdoc />
        public override global::Exa.CreateWebsetParametersExcludeItemSource Read(
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
                        return global::Exa.CreateWebsetParametersExcludeItemSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.CreateWebsetParametersExcludeItemSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.CreateWebsetParametersExcludeItemSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.CreateWebsetParametersExcludeItemSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.CreateWebsetParametersExcludeItemSourceExtensions.ToValueString(value));
        }
    }
}
