
#nullable enable

namespace Exa
{
    /// <summary>
    /// Endpoint-dependent estimated search cost breakdown by retrieval mode. Instant, fast, and auto search responses may include neural search cost. Deep search modes may be reflected only in total.
    /// </summary>
    public sealed partial class CostDollarsOutputSearch
    {
        /// <summary>
        /// Cost of neural search operations.<br/>
        /// Example: 0.007
        /// </summary>
        /// <example>0.007</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("neural")]
        public float? Neural { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutputSearch" /> class.
        /// </summary>
        /// <param name="neural">
        /// Cost of neural search operations.<br/>
        /// Example: 0.007
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostDollarsOutputSearch(
            float? neural)
        {
            this.Neural = neural;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutputSearch" /> class.
        /// </summary>
        public CostDollarsOutputSearch()
        {
        }

    }
}