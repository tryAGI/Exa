
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchStreamChunkVariant2
    {
        /// <summary>
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
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
        public required global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2GroundingItem> Grounding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2Citation>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2Choice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamChunkVariant2" /> class.
        /// </summary>
        /// <param name="grounding">
        /// Field-level grounding for synthesized output.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
        /// <param name="citations"></param>
        /// <param name="choices"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamChunkVariant2(
            global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2GroundingItem> grounding,
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2Citation>? citations,
            global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant2Choice>? choices,
            string type = "grounding")
        {
            this.RequestId = requestId;
            this.Type = type;
            this.Grounding = grounding ?? throw new global::System.ArgumentNullException(nameof(grounding));
            this.Citations = citations;
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamChunkVariant2" /> class.
        /// </summary>
        public SearchStreamChunkVariant2()
        {
        }

    }
}