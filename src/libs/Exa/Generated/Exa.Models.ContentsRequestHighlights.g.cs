
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// Advanced options for controlling highlight extraction. Use this when you need to customize the number of sentences, highlights per URL, or provide a custom query.
    /// </summary>
    public sealed partial class ContentsRequestHighlights
    {
        /// <summary>
        /// Maximum number of characters to return for highlights. Controls the total length of highlight text returned per URL.<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCharacters")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// Deprecated: use maxCharacters instead. The number of sentences to return for each snippet.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSentences")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? NumSentences { get; set; }

        /// <summary>
        /// Deprecated: use maxCharacters instead. The number of snippets to return for each result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightsPerUrl")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? HighlightsPerUrl { get; set; }

        /// <summary>
        /// Custom query to direct the LLM's selection of highlights.<br/>
        /// Example: Key advancements
        /// </summary>
        /// <example>Key advancements</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestHighlights" /> class.
        /// </summary>
        /// <param name="maxCharacters">
        /// Maximum number of characters to return for highlights. Controls the total length of highlight text returned per URL.<br/>
        /// Example: 2000
        /// </param>
        /// <param name="query">
        /// Custom query to direct the LLM's selection of highlights.<br/>
        /// Example: Key advancements
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestHighlights(
            int? maxCharacters,
            string? query)
        {
            this.MaxCharacters = maxCharacters;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestHighlights" /> class.
        /// </summary>
        public ContentsRequestHighlights()
        {
        }
    }
}