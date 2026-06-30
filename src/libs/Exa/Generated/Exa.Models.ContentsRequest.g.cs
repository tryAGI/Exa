
#nullable enable

namespace Exa
{
    /// <summary>
    /// Provide either `ids` or `urls`, but not both.
    /// </summary>
    public sealed partial class ContentsRequest
    {
        /// <summary>
        /// Document IDs obtained from searches.<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </summary>
        /// <example>[https://arxiv.org/pdf/2307.06435]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// URLs to crawl (backwards compatible with the `ids` parameter).<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </summary>
        /// <example>[https://arxiv.org/pdf/2307.06435]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliance")]
        public global::Exa.ContentsRequestCompliance2? Compliance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>? Highlights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Exa.ContentsRequestSummary2? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public global::Exa.ContentsRequestExtras2? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawl")]
        public global::Exa.ContentsRequestLivecrawl2? Livecrawl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawlTimeout")]
        public int? LivecrawlTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxAgeHours")]
        public int? MaxAgeHours { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpages")]
        public int? Subpages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpageTarget")]
        public global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? SubpageTarget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// Document IDs obtained from searches.<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </param>
        /// <param name="urls">
        /// URLs to crawl (backwards compatible with the `ids` parameter).<br/>
        /// Example: [https://arxiv.org/pdf/2307.06435]
        /// </param>
        /// <param name="compliance"></param>
        /// <param name="text"></param>
        /// <param name="highlights"></param>
        /// <param name="summary"></param>
        /// <param name="extras"></param>
        /// <param name="context"></param>
        /// <param name="livecrawl"></param>
        /// <param name="livecrawlTimeout"></param>
        /// <param name="maxAgeHours"></param>
        /// <param name="subpages"></param>
        /// <param name="subpageTarget"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequest(
            global::System.Collections.Generic.IList<string>? ids,
            global::System.Collections.Generic.IList<string>? urls,
            global::Exa.ContentsRequestCompliance2? compliance,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>? text,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>? highlights,
            global::Exa.ContentsRequestSummary2? summary,
            global::Exa.ContentsRequestExtras2? extras,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>? context,
            global::Exa.ContentsRequestLivecrawl2? livecrawl,
            int? livecrawlTimeout,
            int? maxAgeHours,
            int? subpages,
            global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? subpageTarget)
        {
            this.Ids = ids;
            this.Urls = urls;
            this.Compliance = compliance;
            this.Text = text;
            this.Highlights = highlights;
            this.Summary = summary;
            this.Extras = extras;
            this.Context = context;
            this.Livecrawl = livecrawl;
            this.LivecrawlTimeout = livecrawlTimeout;
            this.MaxAgeHours = maxAgeHours;
            this.Subpages = subpages;
            this.SubpageTarget = subpageTarget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequest" /> class.
        /// </summary>
        public ContentsRequest()
        {
        }

    }
}