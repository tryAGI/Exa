
#nullable enable

namespace Exa
{
    /// <summary>
    /// Deep-search synthesized output. Returned for deep search variants.
    /// </summary>
    public sealed partial class SearchResponseOutput
    {
        /// <summary>
        /// Deep-search synthesized content. String by default, or object when outputSchema is provided.
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
        public required global::System.Collections.Generic.IList<global::Exa.SearchResponseOutputGroundingItem> Grounding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseOutput" /> class.
        /// </summary>
        /// <param name="content">
        /// Deep-search synthesized content. String by default, or object when outputSchema is provided.
        /// </param>
        /// <param name="grounding">
        /// Field-level grounding for synthesized output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponseOutput(
            global::Exa.OneOf<string, object> content,
            global::System.Collections.Generic.IList<global::Exa.SearchResponseOutputGroundingItem> grounding)
        {
            this.Content = content;
            this.Grounding = grounding ?? throw new global::System.ArgumentNullException(nameof(grounding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseOutput" /> class.
        /// </summary>
        public SearchResponseOutput()
        {
        }
    }
}