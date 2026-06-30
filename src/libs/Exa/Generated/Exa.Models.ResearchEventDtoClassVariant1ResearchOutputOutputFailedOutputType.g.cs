
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType.Failed,
                _ => null,
            };
        }
    }
}