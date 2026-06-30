
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRunEvent
    {
        /// <summary>
        /// Event ID within the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.AgentRunEventEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AgentRunEventEvent Event { get; set; }

        /// <summary>
        /// Any JSON value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.JsonValueJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.JsonValue Data { get; set; }

        /// <summary>
        /// When the event was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Event ID within the run.
        /// </param>
        /// <param name="event"></param>
        /// <param name="data">
        /// Any JSON value.
        /// </param>
        /// <param name="createdAt">
        /// When the event was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunEvent(
            string id,
            global::Exa.AgentRunEventEvent @event,
            global::Exa.JsonValue data,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Event = @event;
            this.Data = data;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunEvent" /> class.
        /// </summary>
        public AgentRunEvent()
        {
        }

    }
}