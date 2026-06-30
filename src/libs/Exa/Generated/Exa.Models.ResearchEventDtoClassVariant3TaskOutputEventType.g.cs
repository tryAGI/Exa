
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskOutputEventType
    {
        /// <summary>
        /// 
        /// </summary>
        TaskOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3TaskOutputEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskOutputEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskOutputEventType.TaskOutput => "task-output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskOutputEventType? ToEnum(string value)
        {
            return value switch
            {
                "task-output" => ResearchEventDtoClassVariant3TaskOutputEventType.TaskOutput,
                _ => null,
            };
        }
    }
}