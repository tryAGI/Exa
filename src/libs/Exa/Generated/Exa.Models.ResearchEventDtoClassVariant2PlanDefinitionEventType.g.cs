
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanDefinitionEventType
    {
        /// <summary>
        /// 
        /// </summary>
        PlanDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanDefinitionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanDefinitionEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanDefinitionEventType.PlanDefinition => "plan-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanDefinitionEventType? ToEnum(string value)
        {
            return value switch
            {
                "plan-definition" => ResearchEventDtoClassVariant2PlanDefinitionEventType.PlanDefinition,
                _ => null,
            };
        }
    }
}