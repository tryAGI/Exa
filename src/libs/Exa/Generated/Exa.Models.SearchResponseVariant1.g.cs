
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResponseVariant1
    {
        /// <summary>
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// A list of search results containing title, URL, published date, and author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutput> Results { get; set; }

        /// <summary>
        /// Deprecated legacy field. Current production responses may return an empty string; clients should not branch on this value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolvedSearchType")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? ResolvedSearchType { get; set; }

        /// <summary>
        /// Deprecated. Combined context string from search results. Use highlights or text instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Context { get; set; }

        /// <summary>
        /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::Exa.CostDollarsOutput? CostDollars { get; set; }

        /// <summary>
        /// Synthesized output. Returned when outputSchema is provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchSynthesisOutputOutput Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseVariant1" /> class.
        /// </summary>
        /// <param name="results">
        /// A list of search results containing title, URL, published date, and author.
        /// </param>
        /// <param name="output">
        /// Synthesized output. Returned when outputSchema is provided.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
        /// <param name="costDollars">
        /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponseVariant1(
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutput> results,
            global::Exa.SearchSynthesisOutputOutput output,
            string? requestId,
            global::Exa.CostDollarsOutput? costDollars)
        {
            this.RequestId = requestId;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.CostDollars = costDollars;
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponseVariant1" /> class.
        /// </summary>
        public SearchResponseVariant1()
        {
        }

    }
}