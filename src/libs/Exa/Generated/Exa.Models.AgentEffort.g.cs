
#nullable enable

namespace Exa
{
    /// <summary>
    /// Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort.<br/>
    /// Default Value: auto
    /// </summary>
    public enum AgentEffort
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentEffort value)
        {
            return value switch
            {
                AgentEffort.Auto => "auto",
                AgentEffort.High => "high",
                AgentEffort.Low => "low",
                AgentEffort.Medium => "medium",
                AgentEffort.Minimal => "minimal",
                AgentEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentEffort? ToEnum(string value)
        {
            return value switch
            {
                "auto" => AgentEffort.Auto,
                "high" => AgentEffort.High,
                "low" => AgentEffort.Low,
                "medium" => AgentEffort.Medium,
                "minimal" => AgentEffort.Minimal,
                "xhigh" => AgentEffort.Xhigh,
                _ => null,
            };
        }
    }
}