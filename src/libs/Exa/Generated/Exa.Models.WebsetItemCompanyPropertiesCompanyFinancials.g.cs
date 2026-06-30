
#nullable enable

namespace Exa
{
    /// <summary>
    /// Financial information about the company
    /// </summary>
    public sealed partial class WebsetItemCompanyPropertiesCompanyFinancials
    {
        /// <summary>
        /// The annual revenue of the company (USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenueAnnual")]
        public double? RevenueAnnual { get; set; }

        /// <summary>
        /// The total funding raised by the company (USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fundingTotal")]
        public double? FundingTotal { get; set; }

        /// <summary>
        /// The latest funding round
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fundingLatestRound")]
        public global::Exa.WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound? FundingLatestRound { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompanyFinancials" /> class.
        /// </summary>
        /// <param name="revenueAnnual">
        /// The annual revenue of the company (USD)
        /// </param>
        /// <param name="fundingTotal">
        /// The total funding raised by the company (USD)
        /// </param>
        /// <param name="fundingLatestRound">
        /// The latest funding round
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemCompanyPropertiesCompanyFinancials(
            double? revenueAnnual,
            double? fundingTotal,
            global::Exa.WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound? fundingLatestRound)
        {
            this.RevenueAnnual = revenueAnnual;
            this.FundingTotal = fundingTotal;
            this.FundingLatestRound = fundingLatestRound;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompanyFinancials" /> class.
        /// </summary>
        public WebsetItemCompanyPropertiesCompanyFinancials()
        {
        }

    }
}