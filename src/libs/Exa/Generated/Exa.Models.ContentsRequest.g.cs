
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// Provide either `ids` or `urls`, but not both.
    /// </summary>
    public sealed partial class ContentsRequest
    {
        /// <summary>
        /// Document IDs obtained from searches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ids")]
        public global::System.Collections.Generic.IList<string>? Ids { get; set; }

        /// <summary>
        /// URLs to crawl (backwards compatible with the `ids` parameter).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        public global::System.Collections.Generic.IList<string>? Urls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compliance")]
        public global::Exa.ContentsRequestCompliance? Compliance { get; set; }

        /// <summary>
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </summary>
        /// <example>7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userIdentifier")]
        public string? UserIdentifier { get; set; }

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
        public global::Exa.ContentsRequestSummary? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public global::Exa.ContentsRequestExtras? Extras { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshotAsOf")]
        public global::System.DateTime? SnapshotAsOf { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>? Context { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawl")]
        public global::Exa.ContentsRequestLivecrawl? Livecrawl { get; set; }

        /// <summary>
        /// Deprecated. Use `snapshotAsOf` instead. Alias of snapshotAsOf with identical behavior.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawledBeforeDate")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? CrawledBeforeDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequest" /> class.
        /// </summary>
        /// <param name="ids">
        /// Document IDs obtained from searches.
        /// </param>
        /// <param name="urls">
        /// URLs to crawl (backwards compatible with the `ids` parameter).
        /// </param>
        /// <param name="compliance"></param>
        /// <param name="userIdentifier">
        /// An opaque ID your platform assigns to the end user this request is made for, such as a UUID. Lets Exa attribute usage to that end user rather than your whole team. Must not contain personal information such as an email address, phone number, username, or name. Hash such values before sending them. 1 to 64 characters: letters, digits, underscores, and hyphens. Retained even when your team has Zero Data Retention enabled. Does not affect results.<br/>
        /// Example: 7f3a9c52-1d4e-4b8a-9e60-2c5d8a1f0b37
        /// </param>
        /// <param name="text"></param>
        /// <param name="highlights"></param>
        /// <param name="summary"></param>
        /// <param name="extras"></param>
        /// <param name="livecrawlTimeout"></param>
        /// <param name="maxAgeHours"></param>
        /// <param name="snapshotAsOf"></param>
        /// <param name="subpages"></param>
        /// <param name="subpageTarget"></param>
        /// <param name="context"></param>
        /// <param name="livecrawl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequest(
            global::System.Collections.Generic.IList<string>? ids,
            global::System.Collections.Generic.IList<string>? urls,
            global::Exa.ContentsRequestCompliance? compliance,
            string? userIdentifier,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestTextVariant1>? text,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestHighlightsVariant1>? highlights,
            global::Exa.ContentsRequestSummary? summary,
            global::Exa.ContentsRequestExtras? extras,
            int? livecrawlTimeout,
            int? maxAgeHours,
            global::System.DateTime? snapshotAsOf,
            int? subpages,
            global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? subpageTarget,
            global::Exa.OneOf<bool?, global::Exa.ContentsRequestContextVariant1>? context,
            global::Exa.ContentsRequestLivecrawl? livecrawl)
        {
            this.Ids = ids;
            this.Urls = urls;
            this.Compliance = compliance;
            this.UserIdentifier = userIdentifier;
            this.Text = text;
            this.Highlights = highlights;
            this.Summary = summary;
            this.Extras = extras;
            this.LivecrawlTimeout = livecrawlTimeout;
            this.MaxAgeHours = maxAgeHours;
            this.SnapshotAsOf = snapshotAsOf;
            this.Subpages = subpages;
            this.SubpageTarget = subpageTarget;
            this.Context = context;
            this.Livecrawl = livecrawl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequest" /> class.
        /// </summary>
        public ContentsRequest()
        {
        }

    }
}