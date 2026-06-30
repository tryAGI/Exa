
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOperationDataThinkType
    {
        /// <summary>
        /// 
        /// </summary>
        Think,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOperationDataThinkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOperationDataThinkType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOperationDataThinkType.Think => "think",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOperationDataThinkType? ToEnum(string value)
        {
            return value switch
            {
                "think" => ResearchEventDtoClassVariant2PlanOperationDataThinkType.Think,
                _ => null,
            };
        }
    }
}