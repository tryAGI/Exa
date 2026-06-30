#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlType>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlType Read(
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
                        return global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeExtensions.ToValueString(value));
        }
    }
}
