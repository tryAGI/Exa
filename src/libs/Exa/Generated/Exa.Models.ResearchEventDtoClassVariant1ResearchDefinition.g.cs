
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1ResearchDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchDefinitionEventTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant1ResearchDefinitionEventType EventType { get; set; }

        /// <summary>
        /// The complete research instructions as provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// The JSON Schema that will validate the final output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// When this event occurred (Unix timestamp in milliseconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The research request this event belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("researchId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResearchId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchDefinition" /> class.
        /// </summary>
        /// <param name="instructions">
        /// The complete research instructions as provided
        /// </param>
        /// <param name="createdAt">
        /// When this event occurred (Unix timestamp in milliseconds)
        /// </param>
        /// <param name="researchId">
        /// The research request this event belongs to
        /// </param>
        /// <param name="eventType"></param>
        /// <param name="outputSchema">
        /// The JSON Schema that will validate the final output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant1ResearchDefinition(
            string instructions,
            double createdAt,
            string researchId,
            global::Exa.ResearchEventDtoClassVariant1ResearchDefinitionEventType eventType,
            object? outputSchema)
        {
            this.EventType = eventType;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputSchema = outputSchema;
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchDefinition" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1ResearchDefinition()
        {
        }

    }
}