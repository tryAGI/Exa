
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant1ResearchDefinitionEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResearchDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1ResearchDefinitionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1ResearchDefinitionEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1ResearchDefinitionEventType.ResearchDefinition => "research-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1ResearchDefinitionEventType? ToEnum(string value)
        {
            return value switch
            {
                "research-definition" => ResearchEventDtoClassVariant1ResearchDefinitionEventType.ResearchDefinition,
                _ => null,
            };
        }
    }
}