
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesFinancials2
    {
        /// <summary>
        /// Estimated annual revenue in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenueAnnual")]
        public double? RevenueAnnual { get; set; }

        /// <summary>
        /// Total funding raised in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fundingTotal")]
        public double? FundingTotal { get; set; }

        /// <summary>
        /// Most recent funding round, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fundingLatestRound")]
        public global::Exa.SearchResultOutputEntitieVariant1PropertiesFinancialsFundingLatestRound2? FundingLatestRound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesFinancials2" /> class.
        /// </summary>
        /// <param name="revenueAnnual">
        /// Estimated annual revenue in USD.
        /// </param>
        /// <param name="fundingTotal">
        /// Total funding raised in USD.
        /// </param>
        /// <param name="fundingLatestRound">
        /// Most recent funding round, when available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesFinancials2(
            double? revenueAnnual,
            double? fundingTotal,
            global::Exa.SearchResultOutputEntitieVariant1PropertiesFinancialsFundingLatestRound2? fundingLatestRound)
        {
            this.RevenueAnnual = revenueAnnual;
            this.FundingTotal = fundingTotal;
            this.FundingLatestRound = fundingLatestRound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesFinancials2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesFinancials2()
        {
        }

    }
}