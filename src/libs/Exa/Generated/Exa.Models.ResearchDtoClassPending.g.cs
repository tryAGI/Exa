
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassPending
    {
        /// <summary>
        /// Unique identifier for tracking and retrieving this research request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("researchId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResearchId { get; set; }

        /// <summary>
        /// When the research was created (Unix timestamp in milliseconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// The model used for this research request<br/>
        /// Default Value: exa-research
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassPendingModelJsonConverter))]
        public global::Exa.ResearchDtoClassPendingModel? Model { get; set; }

        /// <summary>
        /// The original research instructions provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// The JSON Schema used to validate the output, if provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassPendingStatusJsonConverter))]
        public global::Exa.ResearchDtoClassPendingStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassPending" /> class.
        /// </summary>
        /// <param name="researchId">
        /// Unique identifier for tracking and retrieving this research request
        /// </param>
        /// <param name="createdAt">
        /// When the research was created (Unix timestamp in milliseconds)
        /// </param>
        /// <param name="instructions">
        /// The original research instructions provided
        /// </param>
        /// <param name="model">
        /// The model used for this research request<br/>
        /// Default Value: exa-research
        /// </param>
        /// <param name="outputSchema">
        /// The JSON Schema used to validate the output, if provided
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassPending(
            string researchId,
            double createdAt,
            string instructions,
            global::Exa.ResearchDtoClassPendingModel? model,
            object? outputSchema,
            global::Exa.ResearchDtoClassPendingStatus status)
        {
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
            this.CreatedAt = createdAt;
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputSchema = outputSchema;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassPending" /> class.
        /// </summary>
        public ResearchDtoClassPending()
        {
        }

    }
}