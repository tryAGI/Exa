
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompleted
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedModelJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedModel? Model { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedStatusJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedStatus Status { get; set; }

        /// <summary>
        /// Detailed log of all operations performed during research. Use ?events=true to include this field for debugging or monitoring progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClass>? Events { get; set; }

        /// <summary>
        /// The final research results, containing both raw text and parsed JSON if outputSchema was provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchDtoClassCompletedOutput Output { get; set; }

        /// <summary>
        /// URLs cited during research, sorted by frequency of appearance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitation> Citations { get; set; }

        /// <summary>
        /// Detailed cost breakdown for billing purposes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchDtoClassCompletedCostDollars CostDollars { get; set; }

        /// <summary>
        /// When the research completed (Unix timestamp in milliseconds)
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
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompleted" /> class.
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
        /// <param name="output">
        /// The final research results, containing both raw text and parsed JSON if outputSchema was provided
        /// </param>
        /// <param name="citations">
        /// URLs cited during research, sorted by frequency of appearance
        /// </param>
        /// <param name="costDollars">
        /// Detailed cost breakdown for billing purposes
        /// </param>
        /// <param name="finishedAt">
        /// When the research completed (Unix timestamp in milliseconds)
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
        public ResearchDtoClassCompleted(
            string researchId,
            double createdAt,
            string instructions,
            global::Exa.ResearchDtoClassCompletedOutput output,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitation> citations,
            global::Exa.ResearchDtoClassCompletedCostDollars costDollars,
            double finishedAt,
            global::Exa.ResearchDtoClassCompletedModel? model,
            object? outputSchema,
            global::Exa.ResearchDtoClassCompletedStatus status,
            global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClass>? events)
        {
            this.ResearchId = researchId ?? throw new global::System.ArgumentNullException(nameof(researchId));
            this.CreatedAt = createdAt;
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputSchema = outputSchema;
            this.Status = status;
            this.Events = events;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
            this.CostDollars = costDollars ?? throw new global::System.ArgumentNullException(nameof(costDollars));
            this.FinishedAt = finishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompleted" /> class.
        /// </summary>
        public ResearchDtoClassCompleted()
        {
        }

    }
}