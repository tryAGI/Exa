
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskDefinitionEventType
    {
        /// <summary>
        /// 
        /// </summary>
        TaskDefinition,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3TaskDefinitionEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskDefinitionEventType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskDefinitionEventType.TaskDefinition => "task-definition",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskDefinitionEventType? ToEnum(string value)
        {
            return value switch
            {
                "task-definition" => ResearchEventDtoClassVariant3TaskDefinitionEventType.TaskDefinition,
                _ => null,
            };
        }
    }
}