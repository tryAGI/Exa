
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        Tasks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType.Stop => "stop",
                ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType.Tasks => "tasks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType? ToEnum(string value)
        {
            return value switch
            {
                "stop" => ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType.Stop,
                "tasks" => ResearchEventDtoClassVariant2PlanOutputOutputDiscriminatorOutputType.Tasks,
                _ => null,
            };
        }
    }
}