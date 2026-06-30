
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOutputEventType
    {
        /// <summary>
        /// 
        /// </summary>
        PlanOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOutputEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOutputEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOutputEventType.PlanOutput => "plan-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOutputEventType? ToEnum(string value)
        {
            return value switch
            {
                "plan-output" => ResearchEventDtoClassVariant2PlanOutputEventType.PlanOutput,
                _ => null,
            };
        }
    }
}