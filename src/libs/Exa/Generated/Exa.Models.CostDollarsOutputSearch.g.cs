
#nullable enable

namespace Exa
{
    /// <summary>
    /// Estimated search cost by retrieval mode. Some search types report their cost only in `total`.
    /// </summary>
    public sealed partial class CostDollarsOutputSearch
    {
        /// <summary>
        /// Cost of neural search operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neural")]
        public float? Neural { get; set; }

        /// <summary>
        /// Cost of keyword search operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public float? Keyword { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutputSearch" /> class.
        /// </summary>
        /// <param name="neural">
        /// Cost of neural search operations.
        /// </param>
        /// <param name="keyword">
        /// Cost of keyword search operations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostDollarsOutputSearch(
            float? neural,
            float? keyword)
        {
            this.Neural = neural;
            this.Keyword = keyword;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutputSearch" /> class.
        /// </summary>
        public CostDollarsOutputSearch()
        {
        }

    }
}