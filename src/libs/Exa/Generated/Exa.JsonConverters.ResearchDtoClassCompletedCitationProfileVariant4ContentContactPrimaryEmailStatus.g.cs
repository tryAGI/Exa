#nullable enable

namespace Exa.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus>
    {
        /// <inheritdoc />
        public override global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus Read(
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
                        return global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContactPrimaryEmailStatusExtensions.ToValueString(value));
        }
    }
}
