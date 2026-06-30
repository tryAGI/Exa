
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Monitor
    {
        /// <summary>
        /// The unique identifier for the Monitor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.MonitorObjectJsonConverter))]
        public global::Exa.MonitorObject Object { get; set; }

        /// <summary>
        /// The status of the Monitor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.MonitorStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorStatus Status { get; set; }

        /// <summary>
        /// The id of the Webset the Monitor belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsetId { get; set; }

        /// <summary>
        /// How often the monitor will run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorCadence Cadence { get; set; }

        /// <summary>
        /// Behavior to perform when monitor runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorBehavior Behavior { get; set; }

        /// <summary>
        /// The last run of the monitor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastRun")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorRun LastRun { get; set; }

        /// <summary>
        /// Date and time when the next run will occur in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextRunAt")]
        public global::System.DateTime? NextRunAt { get; set; }

        /// <summary>
        /// Set of key-value pairs you want to associate with this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// When the monitor was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the monitor was last updated
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
        /// Initializes a new instance of the <see cref="Monitor" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the Monitor
        /// </param>
        /// <param name="status">
        /// The status of the Monitor
        /// </param>
        /// <param name="websetId">
        /// The id of the Webset the Monitor belongs to
        /// </param>
        /// <param name="cadence">
        /// How often the monitor will run
        /// </param>
        /// <param name="behavior">
        /// Behavior to perform when monitor runs
        /// </param>
        /// <param name="lastRun">
        /// The last run of the monitor
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
        /// <param name="createdAt">
        /// When the monitor was created
        /// </param>
        /// <param name="updatedAt">
        /// When the monitor was last updated
        /// </param>
        /// <param name="object">
        /// The type of object
        /// </param>
        /// <param name="nextRunAt">
        /// Date and time when the next run will occur in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Monitor(
            string id,
            global::Exa.MonitorStatus status,
            string websetId,
            global::Exa.MonitorCadence cadence,
            global::Exa.MonitorBehavior behavior,
            global::Exa.MonitorRun lastRun,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Exa.MonitorObject @object,
            global::System.DateTime? nextRunAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.WebsetId = websetId ?? throw new global::System.ArgumentNullException(nameof(websetId));
            this.Cadence = cadence ?? throw new global::System.ArgumentNullException(nameof(cadence));
            this.Behavior = behavior ?? throw new global::System.ArgumentNullException(nameof(behavior));
            this.LastRun = lastRun ?? throw new global::System.ArgumentNullException(nameof(lastRun));
            this.NextRunAt = nextRunAt;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Monitor" /> class.
        /// </summary>
        public Monitor()
        {
        }

    }
}