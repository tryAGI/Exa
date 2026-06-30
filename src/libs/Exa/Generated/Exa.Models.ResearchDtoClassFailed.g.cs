
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassFailed
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassFailedModelJsonConverter))]
        public global::Exa.ResearchDtoClassFailedModel? Model { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassFailedStatusJsonConverter))]
        public global::Exa.ResearchDtoClassFailedStatus Status { get; set; }

        /// <summary>
        /// Detailed log of all operations performed during research. Use ?events=true to include this field for debugging or monitoring progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClass>? Events { get; set; }

        /// <summary>
        /// Human-readable error message explaining what went wrong.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// When the research failed (Unix timestamp in milliseconds)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double FinishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassFailed" /> class.
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
        /// <param name="error">
        /// Human-readable error message explaining what went wrong.
        /// </param>
        /// <param name="finishedAt">
        /// When the research failed (Unix timestamp in milliseconds)
        /// </param>
        /// <param name="model">
        /// The model used for this research request<br/>
        /// Default Value: exa-research
        /// </param>
        /// <param name="outputSchema">
        /// The JSON Schema used to validate the output, if provided
        /// </param>
        /// <param name="status"></param>
        /// <param name="events">
        /// Detailed log of all operations performed during research. Use ?events=true to include this field for debugging or monitoring progress.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassFailed(
            string researchId,
            double createdAt,
            string instructions,
            string error,
            double finishedAt,
            global::Exa.ResearchDtoClassFailedModel? model,
            object? outputSchema,
            global::Exa.ResearchDtoClassFailedStatus status,
            global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClass>? events)
        {
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
            this.CreatedAt = createdAt;
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputSchema = outputSchema;
            this.Status = status;
            this.Events = events;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassFailed" /> class.
        /// </summary>
        public ResearchDtoClassFailed()
        {
        }

    }
}