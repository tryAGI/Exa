
#nullable enable

namespace Exa
{
    /// <summary>
    /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
    /// </summary>
    public sealed partial class CostDollarsOutput
    {
        /// <summary>
        /// Estimated total dollar cost for the completed request. This response value is not an invoice record.<br/>
        /// Example: 0.007
        /// </summary>
        /// <example>0.007</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public float? Total { get; set; }

        /// <summary>
        /// Endpoint-dependent estimated search cost breakdown by retrieval mode. Instant, fast, and auto search responses may include neural search cost. Deep search modes may be reflected only in total.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public global::Exa.CostDollarsOutputSearch? Search { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutput" /> class.
        /// </summary>
        /// <param name="total">
        /// Estimated total dollar cost for the completed request. This response value is not an invoice record.<br/>
        /// Example: 0.007
        /// </param>
        /// <param name="search">
        /// Endpoint-dependent estimated search cost breakdown by retrieval mode. Instant, fast, and auto search responses may include neural search cost. Deep search modes may be reflected only in total.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostDollarsOutput(
            float? total,
            global::Exa.CostDollarsOutputSearch? search)
        {
            this.Total = total;
            this.Search = search;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutput" /> class.
        /// </summary>
        public CostDollarsOutput()
        {
        }

    }
}