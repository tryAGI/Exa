
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant3TaskOperationDataSearch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchType Type { get; set; }

        /// <summary>
        /// Search algorithm used (neural for semantic search, keyword for exact matches)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType SearchType { get; set; }

        /// <summary>
        /// What the AI is trying to find with this search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        public string? Goal { get; set; }

        /// <summary>
        /// The exact search query sent to the search engine
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// URLs returned by the search, ranked by relevance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchResult> Results { get; set; }

        /// <summary>
        /// Token cost for processing search result snippets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3TaskOperationDataSearch" /> class.
        /// </summary>
        /// <param name="searchType">
        /// Search algorithm used (neural for semantic search, keyword for exact matches)
        /// </param>
        /// <param name="query">
        /// The exact search query sent to the search engine
        /// </param>
        /// <param name="results">
        /// URLs returned by the search, ranked by relevance
        /// </param>
        /// <param name="pageTokens">
        /// Token cost for processing search result snippets
        /// </param>
        /// <param name="type"></param>
        /// <param name="goal">
        /// What the AI is trying to find with this search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant3TaskOperationDataSearch(
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType searchType,
            string query,
            global::System.Collections.Generic.IList<global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchResult> results,
            double pageTokens,
            global::Exa.ResearchEventDtoClassVariant3TaskOperationDataSearchType type,
            string? goal)
        {
            this.Type = type;
            this.SearchType = searchType;
            this.Goal = goal;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.PageTokens = pageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant3TaskOperationDataSearch" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant3TaskOperationDataSearch()
        {
        }

    }
}