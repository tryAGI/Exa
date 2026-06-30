
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentStopReason
    {
        /// <summary>
        /// 
        /// </summary>
        BudgetReached,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        SchemaSatisfied,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentStopReason value)
        {
            return value switch
            {
                AgentStopReason.BudgetReached => "budget_reached",
                AgentStopReason.Cancelled => "cancelled",
                AgentStopReason.Error => "error",
                AgentStopReason.SchemaSatisfied => "schema_satisfied",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentStopReason? ToEnum(string value)
        {
            return value switch
            {
                "budget_reached" => AgentStopReason.BudgetReached,
                "cancelled" => AgentStopReason.Cancelled,
                "error" => AgentStopReason.Error,
                "schema_satisfied" => AgentStopReason.SchemaSatisfied,
                _ => null,
            };
        }
    }
}