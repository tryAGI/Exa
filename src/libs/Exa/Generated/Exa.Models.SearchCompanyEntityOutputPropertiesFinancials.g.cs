
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchCompanyEntityOutputPropertiesFinancials
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
        public global::Exa.SearchCompanyEntityOutputPropertiesFinancialsFundingLatestRound? FundingLatestRound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCompanyEntityOutputPropertiesFinancials" /> class.
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
        public SearchCompanyEntityOutputPropertiesFinancials(
            double? revenueAnnual,
            double? fundingTotal,
            global::Exa.SearchCompanyEntityOutputPropertiesFinancialsFundingLatestRound? fundingLatestRound)
        {
            this.RevenueAnnual = revenueAnnual;
            this.FundingTotal = fundingTotal;
            this.FundingLatestRound = fundingLatestRound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchCompanyEntityOutputPropertiesFinancials" /> class.
        /// </summary>
        public SearchCompanyEntityOutputPropertiesFinancials()
        {
        }

    }
}