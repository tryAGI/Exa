
#pragma warning disable CS0618 // Type or member is obsolete

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
        /// The url for which you would like to find similar links.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public global::Exa.FindSimilarRequestCategory? Category { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeSourceDomain")]
        public bool? ExcludeSourceDomain { get; set; }

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
        /// Deprecated. List of strings that must be present in the webpage text of results. Matching is approximate (word-level rather than exact phrase), so a multi-word entry can match pages where its words appear separately. Up to 50 strings, each up to 4096 characters. Ignored for the `company` and `people` categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeText")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? IncludeText { get; set; }

        /// <summary>
        /// Deprecated. List of strings that must not be present in the webpage text of results. Matching is approximate (word-level rather than exact phrase). Up to 50 strings, each up to 4096 characters. Ignored for the `company` and `people` categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeText")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? ExcludeText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// The url for which you would like to find similar links.
        /// </param>
        /// <param name="includeDomains"></param>
        /// <param name="excludeDomains"></param>
        /// <param name="startPublishedDate"></param>
        /// <param name="endPublishedDate"></param>
        /// <param name="numResults"></param>
        /// <param name="contents"></param>
        /// <param name="category"></param>
        /// <param name="excludeSourceDomain"></param>
        /// <param name="startCrawlDate"></param>
        /// <param name="endCrawlDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarRequest(
            string url,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::System.DateTime? startPublishedDate,
            global::System.DateTime? endPublishedDate,
            int? numResults,
            global::Exa.ContentsOptions? contents,
            global::Exa.FindSimilarRequestCategory? category,
            bool? excludeSourceDomain,
            global::System.DateTime? startCrawlDate,
            global::System.DateTime? endCrawlDate)
        {
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.StartPublishedDate = startPublishedDate;
            this.EndPublishedDate = endPublishedDate;
            this.NumResults = numResults;
            this.Contents = contents;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Category = category;
            this.ExcludeSourceDomain = excludeSourceDomain;
            this.StartCrawlDate = startCrawlDate;
            this.EndCrawlDate = endCrawlDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest" /> class.
        /// </summary>
        public FindSimilarRequest()
        {
        }

    }
}