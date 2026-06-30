
#nullable enable

namespace Exa
{
    /// <summary>
    /// Advanced options for steering highlight extraction. Pass highlights: true for the highest-quality default; supply this object only when you need to guide selection with your own query.
    /// </summary>
    public sealed partial class SearchMonitorContentsHighlights
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCharacters")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSentences")]
        public int? NumSentences { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightsPerUrl")]
        public int? HighlightsPerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorContentsHighlights" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="maxCharacters"></param>
        /// <param name="numSentences"></param>
        /// <param name="highlightsPerUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMonitorContentsHighlights(
            string? query,
            int? maxCharacters,
            int? numSentences,
            int? highlightsPerUrl)
        {
            this.Query = query;
            this.MaxCharacters = maxCharacters;
            this.NumSentences = numSentences;
            this.HighlightsPerUrl = highlightsPerUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorContentsHighlights" /> class.
        /// </summary>
        public SearchMonitorContentsHighlights()
        {
        }

    }
}