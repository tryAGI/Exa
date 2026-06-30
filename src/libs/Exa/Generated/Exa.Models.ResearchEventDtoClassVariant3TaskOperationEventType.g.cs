
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskOperationEventType
    {
        /// <summary>
        /// 
        /// </summary>
        TaskOperation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3TaskOperationEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskOperationEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskOperationEventType.TaskOperation => "task-operation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskOperationEventType? ToEnum(string value)
        {
            return value switch
            {
                "task-operation" => ResearchEventDtoClassVariant3TaskOperationEventType.TaskOperation,
                _ => null,
            };
        }
    }
}