
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EventMonitorRunCreatedEvent
    {
        /// <summary>
        /// The unique identifier for the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of object<br/>
        /// Default Value: event
        /// </summary>
        /// <default>"event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "event";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.MonitorRun Data { get; set; }

        /// <summary>
        /// The date and time the event was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The type of event<br/>
        /// Default Value: monitor.run.created
        /// </summary>
        /// <default>"monitor.run.created"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "monitor.run.created";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventMonitorRunCreatedEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the event
        /// </param>
        /// <param name="data"></param>
        /// <param name="createdAt">
        /// The date and time the event was created
        /// </param>
        /// <param name="object">
        /// The type of object<br/>
        /// Default Value: event
        /// </param>
        /// <param name="type">
        /// The type of event<br/>
        /// Default Value: monitor.run.created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventMonitorRunCreatedEvent(
            string id,
            global::Exa.MonitorRun data,
            global::System.DateTime createdAt,
            string @object = "event",
            string type = "monitor.run.created")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.CreatedAt = createdAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventMonitorRunCreatedEvent" /> class.
        /// </summary>
        public EventMonitorRunCreatedEvent()
        {
        }

    }
}