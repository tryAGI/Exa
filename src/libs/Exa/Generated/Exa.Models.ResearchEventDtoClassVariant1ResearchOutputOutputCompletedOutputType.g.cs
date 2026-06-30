
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResearchEventDtoClassVariant1ResearchOutputOutputCompletedOutputType.Completed,
                _ => null,
            };
        }
    }
}