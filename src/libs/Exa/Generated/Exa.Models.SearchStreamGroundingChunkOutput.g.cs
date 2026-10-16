
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchStreamGroundingChunkOutput
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"grounding"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "grounding";

        /// <summary>
        /// Field-level grounding for synthesized output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItem> Grounding { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputCitation>? Citations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamGroundingChunkOutput" /> class.
        /// </summary>
        /// <param name="grounding">
        /// Field-level grounding for synthesized output.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="citations"></param>
        /// <param name="choices"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamGroundingChunkOutput(
            global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputGroundingItem> grounding,
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputCitation>? citations,
            global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoice>? choices,
            string type = "grounding")
        {
            this.RequestId = requestId;
            this.Type = type;
            this.Grounding = grounding ?? throw new global::System.ArgumentNullException(nameof(grounding));
            this.Citations = citations;
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamGroundingChunkOutput" /> class.
        /// </summary>
        public SearchStreamGroundingChunkOutput()
        {
        }

    }
}