
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// Content extraction options applied to each search result. All fields are optional.
    /// </summary>
    public sealed partial class SearchMonitorContents
    {
        /// <summary>
        /// Text extraction options for each result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsText>))]
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsText>? Text { get; set; }

        /// <summary>
        /// Text snippets the LLM identifies as most relevant from each page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsHighlights>))]
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsHighlights>? Highlights { get; set; }

        /// <summary>
        /// Return an LLM-generated summary. Pass `true` for defaults, or an object with `query`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SummaryWithMaxTokensOptions>))]
        public global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptions>? Summary { get; set; }

        /// <summary>
        /// Extra parameters to pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public global::Exa.SearchMonitorContentsExtras? Extras { get; set; }

        /// <summary>
        /// The timeout for livecrawling in milliseconds.<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawlTimeout")]
        public int? LivecrawlTimeout { get; set; }

        /// <summary>
        /// Maximum age of cached content, in hours, up to 720. Cached content younger than this is used, and older pages are fetched fresh. `0` always fetches fresh content and `-1` always uses the cache. When omitted, cached content is used when available and pages without it are fetched live.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAgeHours")]
        public int? MaxAgeHours { get; set; }

        /// <summary>
        /// Filter out results with no content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterEmptyResults")]
        public bool? FilterEmptyResults { get; set; }

        /// <summary>
        /// The number of subpages to crawl. The actual number crawled may be limited by system constraints.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpages")]
        public int? Subpages { get; set; }

        /// <summary>
        /// Term to find specific subpages of search results. Can be a single string or an array of strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpageTarget")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? SubpageTarget { get; set; }

        /// <summary>
        /// Deprecated. Use `highlights` or `text` instead. Returns page contents as a combined context string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsContext>))]
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsContext>? Context { get; set; }

        /// <summary>
        /// Deprecated. Use `maxAgeHours` instead. Does not guarantee freshly fetched content. Cannot be combined with `maxAgeHours`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsLivecrawl?, string>))]
        public global::Exa.OneOf<global::Exa.SearchMonitorContentsLivecrawl?, string>? Livecrawl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorContents" /> class.
        /// </summary>
        /// <param name="text">
        /// Text extraction options for each result.
        /// </param>
        /// <param name="highlights">
        /// Text snippets the LLM identifies as most relevant from each page.
        /// </param>
        /// <param name="summary">
        /// Return an LLM-generated summary. Pass `true` for defaults, or an object with `query`.
        /// </param>
        /// <param name="extras">
        /// Extra parameters to pass.
        /// </param>
        /// <param name="livecrawlTimeout">
        /// The timeout for livecrawling in milliseconds.<br/>
        /// Default Value: 10000
        /// </param>
        /// <param name="maxAgeHours">
        /// Maximum age of cached content, in hours, up to 720. Cached content younger than this is used, and older pages are fetched fresh. `0` always fetches fresh content and `-1` always uses the cache. When omitted, cached content is used when available and pages without it are fetched live.
        /// </param>
        /// <param name="filterEmptyResults">
        /// Filter out results with no content
        /// </param>
        /// <param name="subpages">
        /// The number of subpages to crawl. The actual number crawled may be limited by system constraints.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="subpageTarget">
        /// Term to find specific subpages of search results. Can be a single string or an array of strings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMonitorContents(
            global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsText>? text,
            global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsHighlights>? highlights,
            global::Exa.OneOf<bool?, global::Exa.SummaryWithMaxTokensOptions>? summary,
            global::Exa.SearchMonitorContentsExtras? extras,
            int? livecrawlTimeout,
            int? maxAgeHours,
            bool? filterEmptyResults,
            int? subpages,
            global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? subpageTarget)
        {
            this.Text = text;
            this.Highlights = highlights;
            this.Summary = summary;
            this.Extras = extras;
            this.LivecrawlTimeout = livecrawlTimeout;
            this.MaxAgeHours = maxAgeHours;
            this.FilterEmptyResults = filterEmptyResults;
            this.Subpages = subpages;
            this.SubpageTarget = subpageTarget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorContents" /> class.
        /// </summary>
        public SearchMonitorContents()
        {
        }

    }
}