
#nullable enable

namespace Exa
{
    /// <summary>
    /// Optional per-run spending and duration limits for the metered `auto` and `ultra` efforts. Runs that finish early may cost less than the limit.
    /// </summary>
    public sealed partial class AgentBudget
    {
        /// <summary>
        /// Maximum amount this run can spend in US dollars. Accepts $1–$100 and applies only to `auto` and `ultra`; when omitted, the default cap is $5 for `auto` and $20 for `ultra`.
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
        /// Initializes a new instance of the <see cref="AgentBudget" /> class.
        /// </summary>
        /// <param name="maxCostDollars">
        /// Maximum amount this run can spend in US dollars. Accepts $1–$100 and applies only to `auto` and `ultra`; when omitted, the default cap is $5 for `auto` and $20 for `ultra`.
        /// </param>
        /// <param name="maxDurationSeconds">
        /// Soft wall-clock ceiling for the run in seconds. Accepts 300–10,800 (5 minutes to 3 hours) and applies only to `ultra`. As the run approaches the limit, the agent stops starting new work and returns what it has found with `stopReason: "time_limit_reached"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBudget(
            double? maxCostDollars,
            int? maxDurationSeconds)
        {
            this.MaxCostDollars = maxCostDollars;
            this.MaxDurationSeconds = maxDurationSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBudget" /> class.
        /// </summary>
        public AgentBudget()
        {
        }

    }
}