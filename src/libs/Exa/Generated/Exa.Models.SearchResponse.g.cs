
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// Unique identifier for the request<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// A list of search results containing title, URL, published date, and author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Exa.ResultWithContent>? Results { get; set; }

        /// <summary>
        /// For auto searches, indicates which search type was selected.<br/>
        /// Example: auto
        /// </summary>
        /// <example>auto</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.SearchResponseSearchTypeJsonConverter))]
        public global::Exa.SearchResponseSearchType? SearchType { get; set; }

        /// <summary>
        /// Deprecated. Combined context string from search results. Use highlights or text instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Deep-search synthesized output. Returned for deep search variants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Exa.SearchResponseOutput? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::Exa.CostDollars? CostDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
        /// <param name="results">
        /// A list of search results containing title, URL, published date, and author.
        /// </param>
        /// <param name="searchType">
        /// For auto searches, indicates which search type was selected.<br/>
        /// Example: auto
        /// </param>
        /// <param name="context">
        /// Deprecated. Combined context string from search results. Use highlights or text instead.
        /// </param>
        /// <param name="output">
        /// Deep-search synthesized output. Returned for deep search variants.
        /// </param>
        /// <param name="costDollars"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponse(
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.ResultWithContent>? results,
            global::Exa.SearchResponseSearchType? searchType,
            string? context,
            global::Exa.SearchResponseOutput? output,
            global::Exa.CostDollars? costDollars)
        {
            this.RequestId = requestId;
            this.Results = results;
            this.SearchType = searchType;
            this.Context = context;
            this.Output = output;
            this.CostDollars = costDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }
    }
}