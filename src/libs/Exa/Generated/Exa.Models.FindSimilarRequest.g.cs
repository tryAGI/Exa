
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FindSimilarRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeDomains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeDomains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startCrawlDate")]
        public global::System.DateTime? StartCrawlDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endCrawlDate")]
        public global::System.DateTime? EndCrawlDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startPublishedDate")]
        public global::System.DateTime? StartPublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endPublishedDate")]
        public global::System.DateTime? EndPublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numResults")]
        public int? NumResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::Exa.ContentsOptions? Contents { get; set; }

        /// <summary>
        /// The url for which you would like to find similar links.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </summary>
        /// <example>https://arxiv.org/abs/2307.06435</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::Exa.FindSimilarRequestCategory2? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeSourceDomain")]
        public bool? ExcludeSourceDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// The url for which you would like to find similar links.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </param>
        /// <param name="includeDomains"></param>
        /// <param name="excludeDomains"></param>
        /// <param name="startCrawlDate"></param>
        /// <param name="endCrawlDate"></param>
        /// <param name="startPublishedDate"></param>
        /// <param name="endPublishedDate"></param>
        /// <param name="numResults"></param>
        /// <param name="contents"></param>
        /// <param name="category"></param>
        /// <param name="excludeSourceDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarRequest(
            string url,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::System.DateTime? startCrawlDate,
            global::System.DateTime? endCrawlDate,
            global::System.DateTime? startPublishedDate,
            global::System.DateTime? endPublishedDate,
            int? numResults,
            global::Exa.ContentsOptions? contents,
            global::Exa.FindSimilarRequestCategory2? category,
            bool? excludeSourceDomain)
        {
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.StartCrawlDate = startCrawlDate;
            this.EndCrawlDate = endCrawlDate;
            this.StartPublishedDate = startPublishedDate;
            this.EndPublishedDate = endPublishedDate;
            this.NumResults = numResults;
            this.Contents = contents;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Category = category;
            this.ExcludeSourceDomain = excludeSourceDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest" /> class.
        /// </summary>
        public FindSimilarRequest()
        {
        }

    }
}