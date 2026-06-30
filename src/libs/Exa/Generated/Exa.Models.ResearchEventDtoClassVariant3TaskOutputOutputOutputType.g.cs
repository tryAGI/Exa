
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskOutputOutputOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3TaskOutputOutputOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskOutputOutputOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskOutputOutputOutputType.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskOutputOutputOutputType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResearchEventDtoClassVariant3TaskOutputOutputOutputType.Completed,
                _ => null,
            };
        }
    }
}