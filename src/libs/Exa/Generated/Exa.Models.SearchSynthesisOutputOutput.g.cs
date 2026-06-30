
#nullable enable

namespace Exa
{
    /// <summary>
    /// Synthesized output. Returned when outputSchema is provided.
    /// </summary>
    public sealed partial class SearchSynthesisOutputOutput
    {
        /// <summary>
        /// Synthesized content. String by default, or object when outputSchema is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.OneOf<string, object> Content { get; set; }

        /// <summary>
        /// Field-level grounding for synthesized output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItem> Grounding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynthesisOutputOutput" /> class.
        /// </summary>
        /// <param name="content">
        /// Synthesized content. String by default, or object when outputSchema is provided.
        /// </param>
        /// <param name="grounding">
        /// Field-level grounding for synthesized output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSynthesisOutputOutput(
            global::Exa.OneOf<string, object> content,
            global::System.Collections.Generic.IList<global::Exa.SearchSynthesisOutputOutputGroundingItem> grounding)
        {
            this.Content = content;
            this.Grounding = grounding ?? throw new global::System.ArgumentNullException(nameof(grounding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynthesisOutputOutput" /> class.
        /// </summary>
        public SearchSynthesisOutputOutput()
        {
        }

    }
}