
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchSynthesisResponse
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// A list of search results containing title, URL, published date, and author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutput> Results { get; set; }

        /// <summary>
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::Exa.CostDollarsOutput? CostDollars { get; set; }

        /// <summary>
        /// Server-side processing time in milliseconds. May exclude output synthesis time, so it can be lower than end-to-end latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchTime")]
        public double? SearchTime { get; set; }

        /// <summary>
        /// Warnings about the request, such as a field that has no effect. Log them; do not pass them to a model. Omitted when there are none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::Exa.SearchWarningOutput>? Warnings { get; set; }

        /// <summary>
        /// Notices about how the results were produced. Pass them to your model with the results. Omitted when there are none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notices")]
        public global::System.Collections.Generic.IList<global::Exa.SearchNoticeOutput>? Notices { get; set; }

        /// <summary>
        /// Synthesized output. Returned when outputSchema is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchSynthesisOutputOutput Output { get; set; }

        /// <summary>
        /// Deprecated. May be an empty string. Do not branch on this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedSearchType")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ResolvedSearchType { get; set; }

        /// <summary>
        /// Deprecated. Use `results[].highlights` or `results[].text` instead. Combined context string from search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynthesisResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// A list of search results containing title, URL, published date, and author.
        /// </param>
        /// <param name="output">
        /// Synthesized output. Returned when outputSchema is provided.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="costDollars">
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </param>
        /// <param name="searchTime">
        /// Server-side processing time in milliseconds. May exclude output synthesis time, so it can be lower than end-to-end latency.
        /// </param>
        /// <param name="warnings">
        /// Warnings about the request, such as a field that has no effect. Log them; do not pass them to a model. Omitted when there are none.
        /// </param>
        /// <param name="notices">
        /// Notices about how the results were produced. Pass them to your model with the results. Omitted when there are none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchSynthesisResponse(
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutput> results,
            global::Exa.SearchSynthesisOutputOutput output,
            string? requestId,
            global::Exa.CostDollarsOutput? costDollars,
            double? searchTime,
            global::System.Collections.Generic.IList<global::Exa.SearchWarningOutput>? warnings,
            global::System.Collections.Generic.IList<global::Exa.SearchNoticeOutput>? notices)
        {
            this.RequestId = requestId;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.CostDollars = costDollars;
            this.SearchTime = searchTime;
            this.Warnings = warnings;
            this.Notices = notices;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSynthesisResponse" /> class.
        /// </summary>
        public SearchSynthesisResponse()
        {
        }

    }
}