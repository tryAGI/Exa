
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FindSimilarResponse
    {
        /// <summary>
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Deprecated. Combined context string from search results. Use highlights or text instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Context { get; set; }

        /// <summary>
        /// A list of search results containing title, URL, published date, and author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutput>? Results { get; set; }

        /// <summary>
        /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::Exa.CostDollarsOutput? CostDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
        /// <param name="results">
        /// A list of search results containing title, URL, published date, and author.
        /// </param>
        /// <param name="costDollars">
        /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarResponse(
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutput>? results,
            global::Exa.CostDollarsOutput? costDollars)
        {
            this.RequestId = requestId;
            this.Results = results;
            this.CostDollars = costDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResponse" /> class.
        /// </summary>
        public FindSimilarResponse()
        {
        }

    }
}