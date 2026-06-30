
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1ResearchOutputOutputCompletedCostDollars
    {
        /// <summary>
        /// Total cost in USD for this research request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Count of web searches performed. Each search query counts as one search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numSearches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumSearches { get; set; }

        /// <summary>
        /// Count of web pages fully crawled and processed. Only pages that were read in detail are counted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numPages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NumPages { get; set; }

        /// <summary>
        /// Total AI tokens used for reasoning, planning, and generating the final output
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoningTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchOutputOutputCompletedCostDollars" /> class.
        /// </summary>
        /// <param name="total">
        /// Total cost in USD for this research request
        /// </param>
        /// <param name="numSearches">
        /// Count of web searches performed. Each search query counts as one search.
        /// </param>
        /// <param name="numPages">
        /// Count of web pages fully crawled and processed. Only pages that were read in detail are counted.
        /// </param>
        /// <param name="reasoningTokens">
        /// Total AI tokens used for reasoning, planning, and generating the final output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant1ResearchOutputOutputCompletedCostDollars(
            double total,
            double numSearches,
            double numPages,
            double reasoningTokens)
        {
            this.Total = total;
            this.NumSearches = numSearches;
            this.NumPages = numPages;
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchOutputOutputCompletedCostDollars" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1ResearchOutputOutputCompletedCostDollars()
        {
        }

    }
}