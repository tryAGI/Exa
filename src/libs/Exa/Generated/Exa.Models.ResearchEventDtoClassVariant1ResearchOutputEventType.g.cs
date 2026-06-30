
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant1ResearchOutputEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1ResearchOutputEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1ResearchOutputEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1ResearchOutputEventType.ResearchOutput => "research-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1ResearchOutputEventType? ToEnum(string value)
        {
            return value switch
            {
                "research-output" => ResearchEventDtoClassVariant1ResearchOutputEventType.ResearchOutput,
                _ => null,
            };
        }
    }
}