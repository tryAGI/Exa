
#nullable enable

namespace Exa
{
    /// <summary>
    /// Canonicalized request fields stored with the run.
    /// </summary>
    public sealed partial class AgentRunRequest2
    {
        /// <summary>
        /// Natural-language question or instructions for the request.<br/>
        /// Example: What are the most important AI infrastructure funding rounds announced this week?
        /// </summary>
        /// <example>What are the most important AI infrastructure funding rounds announced this week?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.<br/>
        /// Example: Prefer official sources and avoid duplicate results.
        /// </summary>
        /// <example>Prefer official sources and avoid duplicate results.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Exa.AgentRunRequestInput? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.AgentEffortJsonConverter))]
        public global::Exa.AgentEffort? Effort { get; set; }

        /// <summary>
        /// Agent run ID. New run IDs are returned with the `agent_run_` prefix.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </summary>
        /// <example>agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousRunId")]
        public string? PreviousRunId { get; set; }

        /// <summary>
        /// Caller-provided key-value metadata for your own tracking.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </summary>
        /// <example>{"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Exa Connect data providers configured for the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSources")]
        public global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>? DataSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunRequest2" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural-language question or instructions for the request.<br/>
        /// Example: What are the most important AI infrastructure funding rounds announced this week?
        /// </param>
        /// <param name="systemPrompt">
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.<br/>
        /// Example: Prefer official sources and avoid duplicate results.
        /// </param>
        /// <param name="input"></param>
        /// <param name="outputSchema"></param>
        /// <param name="effort">
        /// Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="previousRunId">
        /// Agent run ID. New run IDs are returned with the `agent_run_` prefix.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="metadata">
        /// Caller-provided key-value metadata for your own tracking.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </param>
        /// <param name="dataSources">
        /// Exa Connect data providers configured for the run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunRequest2(
            string? query,
            string? systemPrompt,
            global::Exa.AgentRunRequestInput? input,
            object? outputSchema,
            global::Exa.AgentEffort? effort,
            string? previousRunId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::Exa.AgentDataSourceOutput>? dataSources)
        {
            this.Query = query;
            this.SystemPrompt = systemPrompt;
            this.Input = input;
            this.OutputSchema = outputSchema;
            this.Effort = effort;
            this.PreviousRunId = previousRunId;
            this.Metadata = metadata;
            this.DataSources = dataSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunRequest2" /> class.
        /// </summary>
        public AgentRunRequest2()
        {
        }

    }
}