
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// Content extraction options applied to each search result. All fields are optional.
    /// </summary>
    public sealed partial class SearchMonitorContentsOutput
    {
        /// <summary>
        /// Text extraction options for each result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputText>))]
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>? Text { get; set; }

        /// <summary>
        /// Text snippets the LLM identifies as most relevant from each page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputHighlights>))]
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>? Highlights { get; set; }

        /// <summary>
        /// Return an LLM-generated summary. Pass `true` for defaults, or an object with `query` and `maxTokens`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputSummary>))]
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputSummary>? Summary { get; set; }

        /// <summary>
        /// Extra parameters to pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public global::Exa.SearchMonitorContentsOutputExtras? Extras { get; set; }

        /// <summary>
        /// Deprecated: Use highlights or text instead. Returns page contents as a combined context string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<bool?, global::Exa.SearchMonitorContentsOutputContext>))]
        public global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputContext>? Context { get; set; }

        /// <summary>
        /// Crawl strategy for fetching page content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawl")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>))]
        public global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>? Livecrawl { get; set; }

        /// <summary>
        /// The timeout for livecrawling in milliseconds.<br/>
        /// Default Value: 10000<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawlTimeout")]
        public int? LivecrawlTimeout { get; set; }

        /// <summary>
        /// Maximum age of cached content in hours. Positive values use cached content if it is less than this many hours old; 0 fetches fresh content and is the supported way to apply text rendering options to newly fetched pages; -1 always uses cache; omitted uses fallback fetching when cached content is unavailable. Maximum supported value is 720 hours.<br/>
        /// Example: 24
        /// </summary>
        /// <example>24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAgeHours")]
        public int? MaxAgeHours { get; set; }

        /// <summary>
        /// Filter out results with no content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterEmptyResults")]
        public bool? FilterEmptyResults { get; set; }

        /// <summary>
        /// The number of subpages to crawl. The actual number crawled may be limited by system constraints.<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpages")]
        public int? Subpages { get; set; }

        /// <summary>
        /// Term to find specific subpages of search results. Can be a single string or an array of strings.<br/>
        /// Example: sources
        /// </summary>
        /// <example>sources</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpageTarget")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? SubpageTarget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorContentsOutput" /> class.
        /// </summary>
        /// <param name="text">
        /// Text extraction options for each result.
        /// </param>
        /// <param name="highlights">
        /// Text snippets the LLM identifies as most relevant from each page.
        /// </param>
        /// <param name="summary">
        /// Return an LLM-generated summary. Pass `true` for defaults, or an object with `query` and `maxTokens`.
        /// </param>
        /// <param name="extras">
        /// Extra parameters to pass.
        /// </param>
        /// <param name="livecrawl">
        /// Crawl strategy for fetching page content
        /// </param>
        /// <param name="livecrawlTimeout">
        /// The timeout for livecrawling in milliseconds.<br/>
        /// Default Value: 10000<br/>
        /// Example: 1000
        /// </param>
        /// <param name="maxAgeHours">
        /// Maximum age of cached content in hours. Positive values use cached content if it is less than this many hours old; 0 fetches fresh content and is the supported way to apply text rendering options to newly fetched pages; -1 always uses cache; omitted uses fallback fetching when cached content is unavailable. Maximum supported value is 720 hours.<br/>
        /// Example: 24
        /// </param>
        /// <param name="filterEmptyResults">
        /// Filter out results with no content
        /// </param>
        /// <param name="subpages">
        /// The number of subpages to crawl. The actual number crawled may be limited by system constraints.<br/>
        /// Default Value: 0<br/>
        /// Example: 1
        /// </param>
        /// <param name="subpageTarget">
        /// Term to find specific subpages of search results. Can be a single string or an array of strings.<br/>
        /// Example: sources
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMonitorContentsOutput(
            global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputText>? text,
            global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputHighlights>? highlights,
            global::Exa.OneOf<bool?, global::Exa.SearchMonitorContentsOutputSummary>? summary,
            global::Exa.SearchMonitorContentsOutputExtras? extras,
            global::Exa.OneOf<global::Exa.SearchMonitorContentsOutputLivecrawl?, string>? livecrawl,
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
            this.Livecrawl = livecrawl;
            this.LivecrawlTimeout = livecrawlTimeout;
            this.MaxAgeHours = maxAgeHours;
            this.FilterEmptyResults = filterEmptyResults;
            this.Subpages = subpages;
            this.SubpageTarget = subpageTarget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorContentsOutput" /> class.
        /// </summary>
        public SearchMonitorContentsOutput()
        {
        }

    }
}