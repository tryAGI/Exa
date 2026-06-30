
#nullable enable

namespace Exa
{
    /// <summary>
    /// Model-reported reliability for this field.
    /// </summary>
    public enum AgentGroundingConfidence2
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentGroundingConfidence2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGroundingConfidence2 value)
        {
            return value switch
            {
                AgentGroundingConfidence2.High => "high",
                AgentGroundingConfidence2.Low => "low",
                AgentGroundingConfidence2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGroundingConfidence2? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentGroundingConfidence2.High,
                "low" => AgentGroundingConfidence2.Low,
                "medium" => AgentGroundingConfidence2.Medium,
                _ => null,
            };
        }
    }
}