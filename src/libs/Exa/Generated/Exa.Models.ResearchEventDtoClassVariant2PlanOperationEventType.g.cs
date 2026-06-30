
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOperationEventType
    {
        /// <summary>
        /// 
        /// </summary>
        PlanOperation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOperationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOperationEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOperationEventType.PlanOperation => "plan-operation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOperationEventType? ToEnum(string value)
        {
            return value switch
            {
                "plan-operation" => ResearchEventDtoClassVariant2PlanOperationEventType.PlanOperation,
                _ => null,
            };
        }
    }
}