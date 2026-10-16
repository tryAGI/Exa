
#nullable enable

namespace Exa
{
    /// <summary>
    /// Model-reported reliability for this field.
    /// </summary>
    public enum AgentGroundingConfidence
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
    public static class AgentGroundingConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentGroundingConfidence value)
        {
            return value switch
            {
                AgentGroundingConfidence.High => "high",
                AgentGroundingConfidence.Low => "low",
                AgentGroundingConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentGroundingConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => AgentGroundingConfidence.High,
                "low" => AgentGroundingConfidence.Low,
                "medium" => AgentGroundingConfidence.Medium,
                _ => null,
            };
        }
    }
}