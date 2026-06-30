
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunStatus value)
        {
            return value switch
            {
                AgentRunStatus.Cancelled => "cancelled",
                AgentRunStatus.Completed => "completed",
                AgentRunStatus.Failed => "failed",
                AgentRunStatus.Queued => "queued",
                AgentRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => AgentRunStatus.Cancelled,
                "completed" => AgentRunStatus.Completed,
                "failed" => AgentRunStatus.Failed,
                "queued" => AgentRunStatus.Queued,
                "running" => AgentRunStatus.Running,
                _ => null,
            };
        }
    }
}