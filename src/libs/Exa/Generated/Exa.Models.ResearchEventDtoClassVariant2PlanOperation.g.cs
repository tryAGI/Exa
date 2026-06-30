
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2PlanOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationEventTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationEventType EventType { get; set; }

        /// <summary>
        /// Which plan this operation belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// Unique identifier for this specific operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationId { get; set; }

        /// <summary>
        /// The actual operation performed (think, search, or crawl)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.DataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.Data Data { get; set; }

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
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOperation" /> class.
        /// </summary>
        /// <param name="planId">
        /// Which plan this operation belongs to
        /// </param>
        /// <param name="operationId">
        /// Unique identifier for this specific operation
        /// </param>
        /// <param name="data">
        /// The actual operation performed (think, search, or crawl)
        /// </param>
        /// <param name="createdAt">
        /// When this event occurred (Unix timestamp in milliseconds)
        /// </param>
        /// <param name="researchId">
        /// The research request this event belongs to
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant2PlanOperation(
            string planId,
            string operationId,
            global::Exa.Data data,
            double createdAt,
            string researchId,
            global::Exa.ResearchEventDtoClassVariant2PlanOperationEventType eventType)
        {
            this.EventType = eventType;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.Data = data;
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOperation" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2PlanOperation()
        {
        }

    }
}