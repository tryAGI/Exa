
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
        public global::Exa.ContentsOptionsSummary2? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public global::Exa.ContentsOptionsExtras2? Extras { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public global::Exa.OneOf<bool?, global::Exa.ContentsOptionsContextVariant1>? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("livecrawl")]
        public global::Exa.ContentsOptionsLivecrawl2? Livecrawl { get; set; }

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
        /// Initializes a new instance of the <see cref="ContentsOptions" /> class.
        /// </summary>
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
        public ContentsOptions(
            global::Exa.OneOf<bool?, global::Exa.ContentsOptionsTextVariant1>? text,
            global::Exa.OneOf<bool?, global::Exa.ContentsOptionsHighlightsVariant1>? highlights,
            global::Exa.ContentsOptionsSummary2? summary,
            global::Exa.ContentsOptionsExtras2? extras,
            global::Exa.OneOf<bool?, global::Exa.ContentsOptionsContextVariant1>? context,
            global::Exa.ContentsOptionsLivecrawl2? livecrawl,
            int? livecrawlTimeout,
            int? maxAgeHours,
            int? subpages,
            global::Exa.OneOf<string, global::System.Collections.Generic.IList<string>>? subpageTarget)
        {
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
        /// Initializes a new instance of the <see cref="ContentsOptions" /> class.
        /// </summary>
        public ContentsOptions()
        {
        }

    }
}