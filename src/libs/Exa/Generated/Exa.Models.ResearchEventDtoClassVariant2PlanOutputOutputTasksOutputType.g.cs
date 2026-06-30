
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Tasks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType.Tasks => "tasks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType? ToEnum(string value)
        {
            return value switch
            {
                "tasks" => ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType.Tasks,
                _ => null,
            };
        }
    }
}