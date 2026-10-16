
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContentsOptions
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public global::Exa.OneOf<bool?, global::Exa.ContentsOptionsTextVariant1>? Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public global::Exa.OneOf<bool?, global::Exa.ContentsOptionsHighlightsVariant1>? Highlights { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::Exa.ContentsOptionsSummary? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public global::Exa.ContentsOptionsExtras? Extras { get; set; }

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
        public global::Exa.OneOf<bool?, global::Exa.ContentsOptionsContextVariant1>? Context { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawl")]
        public global::Exa.ContentsOptionsLivecrawl? Livecrawl { get; set; }

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
        /// Initializes a new instance of the <see cref="ContentsOptions" /> class.
        /// </summary>
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
        public ContentsOptions(
            global::Exa.OneOf<bool?, global::Exa.ContentsOptionsTextVariant1>? text,
            global::Exa.OneOf<bool?, global::Exa.ContentsOptionsHighlightsVariant1>? highlights,
            global::Exa.ContentsOptionsSummary? summary,
            global::Exa.ContentsOptionsExtras? extras,
            int? livecrawlTimeout,
            int? maxAgeHours,
            global::System.DateTime? snapshotAsOf,
            int? subpages,
            global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? subpageTarget,
            global::Exa.OneOf<bool?, global::Exa.ContentsOptionsContextVariant1>? context,
            global::Exa.ContentsOptionsLivecrawl? livecrawl)
        {
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
        /// Initializes a new instance of the <see cref="ContentsOptions" /> class.
        /// </summary>
        public ContentsOptions()
        {
        }

    }
}