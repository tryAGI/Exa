
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentRunRequest
    {
        /// <summary>
        /// Natural-language question or instructions for the request.<br/>
        /// Example: What are the most important AI infrastructure funding rounds announced this week?
        /// </summary>
        /// <example>What are the most important AI infrastructure funding rounds announced this week?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.<br/>
        /// Example: Prefer official sources and avoid duplicate results.
        /// </summary>
        /// <example>Prefer official sources and avoid duplicate results.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("systemPrompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// Records to process and records or entities to exclude from the answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Exa.CreateAgentRunRequestInput? Input { get; set; }

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
        /// Completed run ID to continue from. Must belong to the same team.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </summary>
        /// <example>agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousRunId")]
        public string? PreviousRunId { get; set; }

        /// <summary>
        /// Caller-provided metadata stored with the run.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </summary>
        /// <example>{"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Exa Connect data providers to enable for the run. Each entry enables all of that provider's tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSources")]
        public global::System.Collections.Generic.IList<global::Exa.AgentDataSource>? DataSources { get; set; }

        /// <summary>
        /// Accepted for compatibility and currently ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Exa.CreateAgentRunRequestBudget? Budget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequest" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural-language question or instructions for the request.<br/>
        /// Example: What are the most important AI infrastructure funding rounds announced this week?
        /// </param>
        /// <param name="systemPrompt">
        /// Additional instructions that guide generated output or agent behavior. Use this for source preferences, novelty constraints, duplication constraints, or other behavior guidance.<br/>
        /// Example: Prefer official sources and avoid duplicate results.
        /// </param>
        /// <param name="input">
        /// Records to process and records or entities to exclude from the answer.
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="effort">
        /// Cost and reasoning effort preference for the run. `auto` lets Exa choose the appropriate effort.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="previousRunId">
        /// Completed run ID to continue from. Must belong to the same team.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="metadata">
        /// Caller-provided metadata stored with the run.<br/>
        /// Example: {"slack_channel_id":"C123ABC","slack_thread_id":"1745444400.123456","user_id":"U123ABC"}
        /// </param>
        /// <param name="dataSources">
        /// Exa Connect data providers to enable for the run. Each entry enables all of that provider's tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRunRequest(
            string query,
            string? systemPrompt,
            global::Exa.CreateAgentRunRequestInput? input,
            object? outputSchema,
            global::Exa.AgentEffort? effort,
            string? previousRunId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::Exa.AgentDataSource>? dataSources)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.SystemPrompt = systemPrompt;
            this.Input = input;
            this.OutputSchema = outputSchema;
            this.Effort = effort;
            this.PreviousRunId = previousRunId;
            this.Metadata = metadata;
            this.DataSources = dataSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequest" /> class.
        /// </summary>
        public CreateAgentRunRequest()
        {
        }

    }
}