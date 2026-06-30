
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant3TaskDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskDefinitionEventTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant3TaskDefinitionEventType EventType { get; set; }

        /// <summary>
        /// The plan that generated this task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlanId { get; set; }

        /// <summary>
        /// Identifier for tracking this specific task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("taskId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskId { get; set; }

        /// <summary>
        /// What this task should accomplish
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

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
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3TaskDefinition" /> class.
        /// </summary>
        /// <param name="planId">
        /// The plan that generated this task
        /// </param>
        /// <param name="taskId">
        /// Identifier for tracking this specific task
        /// </param>
        /// <param name="instructions">
        /// What this task should accomplish
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
        public ResearchEventDtoClassVariant3TaskDefinition(
            string planId,
            string taskId,
            string instructions,
            double createdAt,
            string researchId,
            global::Exa.ResearchEventDtoClassVariant3TaskDefinitionEventType eventType)
        {
            this.EventType = eventType;
            this.PlanId = planId ?? throw new global::System.ArgumentNullException(nameof(planId));
            this.TaskId = taskId ?? throw new global::System.ArgumentNullException(nameof(taskId));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.CreatedAt = createdAt;
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3TaskDefinition" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant3TaskDefinition()
        {
        }

    }
}