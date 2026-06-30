
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentRunEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        AgentRunCancelled,
        /// <summary>
        /// 
        /// </summary>
        AgentRunCompleted,
        /// <summary>
        /// 
        /// </summary>
        AgentRunCreated,
        /// <summary>
        /// 
        /// </summary>
        AgentRunFailed,
        /// <summary>
        /// 
        /// </summary>
        AgentRunStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRunEventEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRunEventEvent value)
        {
            return value switch
            {
                AgentRunEventEvent.AgentRunCancelled => "agent_run.cancelled",
                AgentRunEventEvent.AgentRunCompleted => "agent_run.completed",
                AgentRunEventEvent.AgentRunCreated => "agent_run.created",
                AgentRunEventEvent.AgentRunFailed => "agent_run.failed",
                AgentRunEventEvent.AgentRunStarted => "agent_run.started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRunEventEvent? ToEnum(string value)
        {
            return value switch
            {
                "agent_run.cancelled" => AgentRunEventEvent.AgentRunCancelled,
                "agent_run.completed" => AgentRunEventEvent.AgentRunCompleted,
                "agent_run.created" => AgentRunEventEvent.AgentRunCreated,
                "agent_run.failed" => AgentRunEventEvent.AgentRunFailed,
                "agent_run.started" => AgentRunEventEvent.AgentRunStarted,
                _ => null,
            };
        }
    }
}