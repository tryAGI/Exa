
#nullable enable

namespace Exa
{
    /// <summary>
    /// Canonicalized request fields stored with the run.
    /// </summary>
    public sealed partial class AgentRunRequest
    {
        /// <summary>
        /// Natural-language question or instructions for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort. `ultra` is the highest-effort tier for work where completeness and thoroughness matter more than latency or cost, including large list building, deep multi-source research, and criteria that are hard to verify.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.AgentEffortJsonConverter))]
        public global::Exa.AgentEffort? Effort { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Exa.AgentRunRequestInput? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? OutputSchema { get; set; }

        /// <summary>
        /// Agent run ID. New run IDs are returned with the `agent_run_` prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousRunId")]
        public string? PreviousRunId { get; set; }

        /// <summary>
        /// Caller-provided key-value metadata for your own tracking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Exa Connect data providers configured for the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSources")]
        public global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>? DataSources { get; set; }

        /// <summary>
        /// Optional per-run spending and duration limits for the metered `auto` and `ultra` efforts. Runs that finish early may cost less than the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        public global::Exa.AgentBudgetOutput? Budget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural-language question or instructions for the request.
        /// </param>
        /// <param name="systemPrompt">
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.
        /// </param>
        /// <param name="effort">
        /// Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort. `ultra` is the highest-effort tier for work where completeness and thoroughness matter more than latency or cost, including large list building, deep multi-source research, and criteria that are hard to verify.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="input"></param>
        /// <param name="outputSchema"></param>
        /// <param name="previousRunId">
        /// Agent run ID. New run IDs are returned with the `agent_run_` prefix.
        /// </param>
        /// <param name="metadata">
        /// Caller-provided key-value metadata for your own tracking.
        /// </param>
        /// <param name="dataSources">
        /// Exa Connect data providers configured for the run.
        /// </param>
        /// <param name="budget">
        /// Optional per-run spending and duration limits for the metered `auto` and `ultra` efforts. Runs that finish early may cost less than the limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunRequest(
            string? query,
            string? systemPrompt,
            global::Exa.AgentEffort? effort,
            global::Exa.AgentRunRequestInput? input,
            global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? outputSchema,
            string? previousRunId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>? dataSources,
            global::Exa.AgentBudgetOutput? budget)
        {
            this.Query = query;
            this.SystemPrompt = systemPrompt;
            this.Effort = effort;
            this.Input = input;
            this.OutputSchema = outputSchema;
            this.PreviousRunId = previousRunId;
            this.Metadata = metadata;
            this.DataSources = dataSources;
            this.Budget = budget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunRequest" /> class.
        /// </summary>
        public AgentRunRequest()
        {
        }

    }
}