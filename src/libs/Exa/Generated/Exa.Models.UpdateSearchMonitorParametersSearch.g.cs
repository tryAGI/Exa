
#nullable enable

namespace Exa
{
    /// <summary>
    /// Partial search params to merge. All fields are optional for updates.
    /// </summary>
    public sealed partial class UpdateSearchMonitorParametersSearch
    {
        /// <summary>
        /// The query string for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Number of results to return. Limits vary by search type. The maximum public limit is 100 results. Contact sales (hello@exa.ai) to discuss higher limits.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// Restrict search results to these domains.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDomains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// Exclude these domains from search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeDomains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Content extraction options applied to each search result. All fields are optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::Exa.SearchMonitorContents? Contents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchMonitorParametersSearch" /> class.
        /// </summary>
        /// <param name="query">
        /// The query string for the search.
        /// </param>
        /// <param name="numResults">
        /// Number of results to return. Limits vary by search type. The maximum public limit is 100 results. Contact sales (hello@exa.ai) to discuss higher limits.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="includeDomains">
        /// Restrict search results to these domains.
        /// </param>
        /// <param name="excludeDomains">
        /// Exclude these domains from search results.
        /// </param>
        /// <param name="contents">
        /// Content extraction options applied to each search result. All fields are optional.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSearchMonitorParametersSearch(
            string? query,
            int? numResults,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::Exa.SearchMonitorContents? contents)
        {
            this.Query = query;
            this.NumResults = numResults;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.Contents = contents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSearchMonitorParametersSearch" /> class.
        /// </summary>
        public UpdateSearchMonitorParametersSearch()
        {
        }

    }
}