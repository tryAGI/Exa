
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskOperationDataThinkType
    {
        /// <summary>
        /// 
        /// </summary>
        Think,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3TaskOperationDataThinkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskOperationDataThinkType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskOperationDataThinkType.Think => "think",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskOperationDataThinkType? ToEnum(string value)
        {
            return value switch
            {
                "think" => ResearchEventDtoClassVariant3TaskOperationDataThinkType.Think,
                _ => null,
            };
        }
    }
}