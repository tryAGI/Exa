
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchMonitorRun
    {
        /// <summary>
        /// The unique identifier for the run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The monitor this run belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MonitorId { get; set; }

        /// <summary>
        /// The status of the run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.SearchMonitorRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchMonitorRunStatus Status { get; set; }

        /// <summary>
        /// The output of the run. Null until the run completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Exa.SearchMonitorRunOutput2? Output { get; set; }

        /// <summary>
        /// The reason the run failed. Null unless status is `failed`. `source_not_available` means the search requested a domain Exa cannot return (remove it from the search), and `forbidden` means the request was otherwise not permitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failReason")]
        public global::Exa.SearchMonitorRunFailReason2? FailReason { get; set; }

        /// <summary>
        /// When the run started executing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startedAt")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the run completed successfully
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// When the run failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedAt")]
        public global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// When the run was cancelled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cancelledAt")]
        public global::System.DateTime? CancelledAt { get; set; }

        /// <summary>
        /// Total execution time in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("durationMs")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// When the run was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the run was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorRun" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the run
        /// </param>
        /// <param name="monitorId">
        /// The monitor this run belongs to
        /// </param>
        /// <param name="status">
        /// The status of the run
        /// </param>
        /// <param name="createdAt">
        /// When the run was created
        /// </param>
        /// <param name="updatedAt">
        /// When the run was last updated
        /// </param>
        /// <param name="output">
        /// The output of the run. Null until the run completes.
        /// </param>
        /// <param name="failReason">
        /// The reason the run failed. Null unless status is `failed`. `source_not_available` means the search requested a domain Exa cannot return (remove it from the search), and `forbidden` means the request was otherwise not permitted.
        /// </param>
        /// <param name="startedAt">
        /// When the run started executing
        /// </param>
        /// <param name="completedAt">
        /// When the run completed successfully
        /// </param>
        /// <param name="failedAt">
        /// When the run failed
        /// </param>
        /// <param name="cancelledAt">
        /// When the run was cancelled
        /// </param>
        /// <param name="durationMs">
        /// Total execution time in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMonitorRun(
            string id,
            string monitorId,
            global::Exa.SearchMonitorRunStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Exa.SearchMonitorRunOutput2? output,
            global::Exa.SearchMonitorRunFailReason2? failReason,
            global::System.DateTime? startedAt,
            global::System.DateTime? completedAt,
            global::System.DateTime? failedAt,
            global::System.DateTime? cancelledAt,
            int? durationMs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MonitorId = monitorId ?? throw new global::System.ArgumentNullException(nameof(monitorId));
            this.Status = status;
            this.Output = output;
            this.FailReason = failReason;
            this.StartedAt = startedAt;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.CancelledAt = cancelledAt;
            this.DurationMs = durationMs;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorRun" /> class.
        /// </summary>
        public SearchMonitorRun()
        {
        }

    }
}