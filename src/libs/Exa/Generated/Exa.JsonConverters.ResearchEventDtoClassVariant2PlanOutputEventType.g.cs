#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchEventDtoClassVariant2PlanOutputEventTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchEventDtoClassVariant2PlanOutputEventType>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchEventDtoClassVariant2PlanOutputEventType Read(
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
                        return global::Exa.ResearchEventDtoClassVariant2PlanOutputEventTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.ResearchEventDtoClassVariant2PlanOutputEventType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.ResearchEventDtoClassVariant2PlanOutputEventType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchEventDtoClassVariant2PlanOutputEventType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.ResearchEventDtoClassVariant2PlanOutputEventTypeExtensions.ToValueString(value));
        }
    }
}
