
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRun
    {
        /// <summary>
        /// Agent run ID. New run IDs are returned with the `agent_run_` prefix.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </summary>
        /// <example>agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"agent_run"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "agent_run";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.AgentRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AgentRunStatus Status { get; set; }

        /// <summary>
        /// Why the run stopped. `null` while the run is queued or running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopReason")]
        public global::Exa.AgentStopReason? StopReason { get; set; }

        /// <summary>
        /// When the run was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::Exa.AgentRunRequest2? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AgentRunOutput Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AgentUsage Usage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AgentCostDollars CostDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Agent run ID. New run IDs are returned with the `agent_run_` prefix.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="status"></param>
        /// <param name="createdAt">
        /// When the run was created
        /// </param>
        /// <param name="output"></param>
        /// <param name="usage"></param>
        /// <param name="costDollars"></param>
        /// <param name="stopReason">
        /// Why the run stopped. `null` while the run is queued or running.
        /// </param>
        /// <param name="completedAt"></param>
        /// <param name="request"></param>
        /// <param name="object"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRun(
            string id,
            global::Exa.AgentRunStatus status,
            global::System.DateTime createdAt,
            global::Exa.AgentRunOutput output,
            global::Exa.AgentUsage usage,
            global::Exa.AgentCostDollars costDollars,
            global::Exa.AgentStopReason? stopReason,
            global::System.DateTime? completedAt,
            global::Exa.AgentRunRequest2? request,
            string @object = "agent_run")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.StopReason = stopReason;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.Request = request;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.CostDollars = costDollars ?? throw new global::System.ArgumentNullException(nameof(costDollars));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRun" /> class.
        /// </summary>
        public AgentRun()
        {
        }

    }
}