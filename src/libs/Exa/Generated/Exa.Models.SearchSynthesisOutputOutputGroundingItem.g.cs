
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchSynthesisOutputOutputGroundingItem
    {
        /// <summary>
        /// Field path in output.content, for example content or companies[0].funding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// Sources supporting this output field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation> Citations { get; set; }

        /// <summary>
        /// Model-reported reliability for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.SearchSynthesisOutputOutputGroundingItemConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynthesisOutputOutputGroundingItem" /> class.
        /// </summary>
        /// <param name="field">
        /// Field path in output.content, for example content or companies[0].funding.
        /// </param>
        /// <param name="citations">
        /// Sources supporting this output field.
        /// </param>
        /// <param name="confidence">
        /// Model-reported reliability for this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSynthesisOutputOutputGroundingItem(
            string field,
            global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItemCitation> citations,
            global::Exa.SearchSynthesisOutputOutputGroundingItemConfidence confidence)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynthesisOutputOutputGroundingItem" /> class.
        /// </summary>
        public SearchSynthesisOutputOutputGroundingItem()
        {
        }

    }
}