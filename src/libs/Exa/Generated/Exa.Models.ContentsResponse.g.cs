
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContentsResponse
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutput>? Results { get; set; }

        /// <summary>
        /// Status information for each requested URL or document ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        public global::System.Collections.Generic.IList<global::Exa.ContentsResponseStatuse>? Statuses { get; set; }

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
        /// Initializes a new instance of the <see cref="ContentsResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="results"></param>
        /// <param name="statuses">
        /// Status information for each requested URL or document ID.
        /// </param>
        /// <param name="costDollars">
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </param>
        /// <param name="searchTime">
        /// Server-side processing time in milliseconds. May exclude output synthesis time, so it can be lower than end-to-end latency.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsResponse(
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutput>? results,
            global::System.Collections.Generic.IList<global::Exa.ContentsResponseStatuse>? statuses,
            global::Exa.CostDollarsOutput? costDollars,
            double? searchTime)
        {
            this.RequestId = requestId;
            this.Results = results;
            this.Statuses = statuses;
            this.CostDollars = costDollars;
            this.SearchTime = searchTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsResponse" /> class.
        /// </summary>
        public ContentsResponse()
        {
        }

    }
}