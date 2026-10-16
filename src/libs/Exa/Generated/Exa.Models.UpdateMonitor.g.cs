
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateMonitor
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The status of the monitor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.UpdateMonitorStatusJsonConverter))]
        public global::Exa.UpdateMonitorStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        public global::Exa.MonitorCadence? Cadence { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("behavior")]
        public global::Exa.MonitorBehavior? Behavior { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitor" /> class.
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="status">
        /// The status of the monitor.
        /// </param>
        /// <param name="cadence"></param>
        /// <param name="behavior"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateMonitor(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::Exa.UpdateMonitorStatus? status,
            global::Exa.MonitorCadence? cadence,
            global::Exa.MonitorBehavior? behavior)
        {
            this.Metadata = metadata;
            this.Status = status;
            this.Cadence = cadence;
            this.Behavior = behavior;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMonitor" /> class.
        /// </summary>
        public UpdateMonitor()
        {
        }

    }
}