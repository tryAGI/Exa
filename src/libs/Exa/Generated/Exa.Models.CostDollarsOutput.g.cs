
#nullable enable

namespace Exa
{
    /// <summary>
    /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
    /// </summary>
    public sealed partial class CostDollarsOutput
    {
        /// <summary>
        /// Estimated total dollar cost for the completed request. This response value is not an invoice record.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public float? Total { get; set; }

        /// <summary>
        /// Estimated search cost by retrieval mode. Some search types report their cost only in `total`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public global::Exa.CostDollarsOutputSearch? Search { get; set; }

        /// <summary>
        /// Cost of synthesized summary generation for search requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public float? Summary { get; set; }

        /// <summary>
        /// Estimated cost breakdown for standalone content retrieval (text, highlights, and summaries billed outside the bundled search price).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contents")]
        public global::Exa.CostDollarsOutputContents? Contents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutput" /> class.
        /// </summary>
        /// <param name="total">
        /// Estimated total dollar cost for the completed request. This response value is not an invoice record.
        /// </param>
        /// <param name="search">
        /// Estimated search cost by retrieval mode. Some search types report their cost only in `total`.
        /// </param>
        /// <param name="summary">
        /// Cost of synthesized summary generation for search requests.
        /// </param>
        /// <param name="contents">
        /// Estimated cost breakdown for standalone content retrieval (text, highlights, and summaries billed outside the bundled search price).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostDollarsOutput(
            float? total,
            global::Exa.CostDollarsOutputSearch? search,
            float? summary,
            global::Exa.CostDollarsOutputContents? contents)
        {
            this.Total = total;
            this.Search = search;
            this.Summary = summary;
            this.Contents = contents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutput" /> class.
        /// </summary>
        public CostDollarsOutput()
        {
        }

    }
}