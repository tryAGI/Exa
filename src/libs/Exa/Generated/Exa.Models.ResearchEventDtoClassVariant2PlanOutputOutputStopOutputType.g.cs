
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOutputOutputStopOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType? ToEnum(string value)
        {
            return value switch
            {
                "stop" => ResearchEventDtoClassVariant2PlanOutputOutputStopOutputType.Stop,
                _ => null,
            };
        }
    }
}