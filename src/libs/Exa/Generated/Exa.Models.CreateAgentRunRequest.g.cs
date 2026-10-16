
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateAgentRunRequest
    {
        /// <summary>
        /// Natural-language question or instructions for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

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
        /// Records to process and records or entities to exclude from the answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::Exa.CreateAgentRunRequestInput? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? OutputSchema { get; set; }

        /// <summary>
        /// Completed run ID to continue from. Must belong to the same team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousRunId")]
        public string? PreviousRunId { get; set; }

        /// <summary>
        /// Caller-provided metadata stored with the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Exa Connect data providers to enable for the run. Each entry enables all of that provider's tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSources")]
        public global::System.Collections.Generic.IList<global::Exa.AgentDataSource>? DataSources { get; set; }

        /// <summary>
        /// Optional per-run spending and duration limits for the metered `auto` and `ultra` efforts. Runs that finish early may cost less than the limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budget")]
        public global::Exa.AgentBudget? Budget { get; set; }

        /// <summary>
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </summary>
        /// <example>7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIdentifier")]
        public string? UserIdentifier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequest" /> class.
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
        /// <param name="input">
        /// Records to process and records or entities to exclude from the answer.
        /// </param>
        /// <param name="outputSchema"></param>
        /// <param name="previousRunId">
        /// Completed run ID to continue from. Must belong to the same team.
        /// </param>
        /// <param name="metadata">
        /// Caller-provided metadata stored with the run.
        /// </param>
        /// <param name="dataSources">
        /// Exa Connect data providers to enable for the run. Each entry enables all of that provider's tools.
        /// </param>
        /// <param name="budget">
        /// Optional per-run spending and duration limits for the metered `auto` and `ultra` efforts. Runs that finish early may cost less than the limit.
        /// </param>
        /// <param name="userIdentifier">
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRunRequest(
            string query,
            string? systemPrompt,
            global::Exa.AgentEffort? effort,
            global::Exa.CreateAgentRunRequestInput? input,
            global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? outputSchema,
            string? previousRunId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::Exa.AgentDataSource>? dataSources,
            global::Exa.AgentBudget? budget,
            string? userIdentifier)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.SystemPrompt = systemPrompt;
            this.Effort = effort;
            this.Input = input;
            this.OutputSchema = outputSchema;
            this.PreviousRunId = previousRunId;
            this.Metadata = metadata;
            this.DataSources = dataSources;
            this.Budget = budget;
            this.UserIdentifier = userIdentifier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRunRequest" /> class.
        /// </summary>
        public CreateAgentRunRequest()
        {
        }

    }
}