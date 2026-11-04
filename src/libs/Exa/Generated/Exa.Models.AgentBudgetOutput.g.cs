
#nullable enable

namespace Exa
{
    /// <summary>
    /// Per-run cost or contact-enrichment limits, depending on effort, and an `ultra` duration limit.
    /// </summary>
    public sealed partial class AgentBudgetOutput
    {
        /// <summary>
        /// Accepts $1 to $100. For `auto` and `ultra`, caps total run cost with default caps of $5 and $20 respectively. For fixed efforts, caps contact-enrichment calls using the budget remaining after the fixed request price, without limiting research or reasoning steps. Fixed efforts have no default cap, and an explicit cap must cover the fixed request price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCostDollars")]
        public double? MaxCostDollars { get; set; }

        /// <summary>
        /// Soft wall-clock ceiling for the run in seconds. Accepts 300–10,800 (5 minutes to 3 hours) and applies only to `ultra`. As the run approaches the limit, the agent stops starting new work and returns what it has found with `stopReason: "time_limit_reached"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDurationSeconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBudgetOutput" /> class.
        /// </summary>
        /// <param name="maxCostDollars">
        /// Accepts $1 to $100. For `auto` and `ultra`, caps total run cost with default caps of $5 and $20 respectively. For fixed efforts, caps contact-enrichment calls using the budget remaining after the fixed request price, without limiting research or reasoning steps. Fixed efforts have no default cap, and an explicit cap must cover the fixed request price.
        /// </param>
        /// <param name="maxDurationSeconds">
        /// Soft wall-clock ceiling for the run in seconds. Accepts 300–10,800 (5 minutes to 3 hours) and applies only to `ultra`. As the run approaches the limit, the agent stops starting new work and returns what it has found with `stopReason: "time_limit_reached"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBudgetOutput(
            double? maxCostDollars,
            int? maxDurationSeconds)
        {
            this.MaxCostDollars = maxCostDollars;
            this.MaxDurationSeconds = maxDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBudgetOutput" /> class.
        /// </summary>
        public AgentBudgetOutput()
        {
        }

    }
}