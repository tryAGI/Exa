
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorRun
    {
        /// <summary>
        /// The unique identifier for the Monitor Run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.MonitorRunObjectJsonConverter))]
        public global::Exa.MonitorRunObject Object { get; set; }

        /// <summary>
        /// The status of the Monitor Run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.MonitorRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorRunStatus Status { get; set; }

        /// <summary>
        /// The monitor that the run is associated with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MonitorId { get; set; }

        /// <summary>
        /// The type of the Monitor Run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.MonitorRunTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorRunType Type { get; set; }

        /// <summary>
        /// When the run completed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completedAt")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// When the run failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedAt")]
        public global::System.DateTime? FailedAt { get; set; }

        /// <summary>
        /// The reason the run failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failedReason")]
        public string? FailedReason { get; set; }

        /// <summary>
        /// When the run was canceled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canceledAt")]
        public global::System.DateTime? CanceledAt { get; set; }

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
        /// Initializes a new instance of the <see cref="MonitorRun" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the Monitor Run
        /// </param>
        /// <param name="status">
        /// The status of the Monitor Run
        /// </param>
        /// <param name="monitorId">
        /// The monitor that the run is associated with
        /// </param>
        /// <param name="type">
        /// The type of the Monitor Run
        /// </param>
        /// <param name="createdAt">
        /// When the run was created
        /// </param>
        /// <param name="updatedAt">
        /// When the run was last updated
        /// </param>
        /// <param name="object">
        /// The type of object
        /// </param>
        /// <param name="completedAt">
        /// When the run completed
        /// </param>
        /// <param name="failedAt">
        /// When the run failed
        /// </param>
        /// <param name="failedReason">
        /// The reason the run failed
        /// </param>
        /// <param name="canceledAt">
        /// When the run was canceled
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorRun(
            string id,
            global::Exa.MonitorRunStatus status,
            string monitorId,
            global::Exa.MonitorRunType type,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Exa.MonitorRunObject @object,
            global::System.DateTime? completedAt,
            global::System.DateTime? failedAt,
            string? failedReason,
            global::System.DateTime? canceledAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.MonitorId = monitorId ?? throw new global::System.ArgumentNullException(nameof(monitorId));
            this.Type = type;
            this.CompletedAt = completedAt;
            this.FailedAt = failedAt;
            this.FailedReason = failedReason;
            this.CanceledAt = canceledAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorRun" /> class.
        /// </summary>
        public MonitorRun()
        {
        }

    }
}