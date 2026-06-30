
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant3TaskOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationEventTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationEventType EventType { get; set; }

        /// <summary>
        /// The plan that owns this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// Which task is performing this operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// Unique identifier for this specific operation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OperationId { get; set; }

        /// <summary>
        /// The actual operation performed within this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.Data2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.Data2 Data { get; set; }

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
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3TaskOperation" /> class.
        /// </summary>
        /// <param name="planId">
        /// The plan that owns this task
        /// </param>
        /// <param name="taskId">
        /// Which task is performing this operation
        /// </param>
        /// <param name="operationId">
        /// Unique identifier for this specific operation
        /// </param>
        /// <param name="data">
        /// The actual operation performed within this task
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
        public ResearchEventDtoClassVariant3TaskOperation(
            string planId,
            string taskId,
            string operationId,
            global::Exa.Data2 data,
            double createdAt,
            string researchId,
            global::Exa.ResearchEventDtoClassVariant3TaskOperationEventType eventType)
        {
            this.EventType = eventType;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.OperationId = operationId ?? throw new global::System.ArgumentNullException(nameof(operationId));
            this.Data = data;
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3TaskOperation" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant3TaskOperation()
        {
        }

    }
}