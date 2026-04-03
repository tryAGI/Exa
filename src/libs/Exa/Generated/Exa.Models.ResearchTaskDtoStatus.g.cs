
#nullable enable

namespace Exa
{
    /// <summary>
    /// The current status of the research task
    /// </summary>
    public enum ResearchTaskDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchTaskDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchTaskDtoStatus value)
        {
            return value switch
            {
                ResearchTaskDtoStatus.Completed => "completed",
                ResearchTaskDtoStatus.Failed => "failed",
                ResearchTaskDtoStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchTaskDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResearchTaskDtoStatus.Completed,
                "failed" => ResearchTaskDtoStatus.Failed,
                "running" => ResearchTaskDtoStatus.Running,
                _ => null,
            };
        }
    }
}