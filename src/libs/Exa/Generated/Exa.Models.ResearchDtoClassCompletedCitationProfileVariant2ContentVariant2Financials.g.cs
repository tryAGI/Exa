
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Financials
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue_annual")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueAnnual? RevenueAnnual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue_range")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueRange? RevenueRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue_growth")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueGrowth? RevenueGrowth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_funding")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsTotalFunding? TotalFunding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_round")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRound? LastRound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("market_cap")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsMarketCap? MarketCap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acquisitions")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitionsJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions? Acquisitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipo_date")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDateJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDate? IpoDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("funding_rounds")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRound>? FundingRounds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Financials" /> class.
        /// </summary>
        /// <param name="revenueAnnual"></param>
        /// <param name="revenueRange"></param>
        /// <param name="revenueGrowth"></param>
        /// <param name="totalFunding"></param>
        /// <param name="lastRound"></param>
        /// <param name="marketCap"></param>
        /// <param name="acquisitions"></param>
        /// <param name="ipoDate"></param>
        /// <param name="fundingRounds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Financials(
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueAnnual? revenueAnnual,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueRange? revenueRange,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueGrowth? revenueGrowth,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsTotalFunding? totalFunding,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRound? lastRound,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsMarketCap? marketCap,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsAcquisitions? acquisitions,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsIpoDate? ipoDate,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRound>? fundingRounds)
        {
            this.RevenueAnnual = revenueAnnual;
            this.RevenueRange = revenueRange;
            this.RevenueGrowth = revenueGrowth;
            this.TotalFunding = totalFunding;
            this.LastRound = lastRound;
            this.MarketCap = marketCap;
            this.Acquisitions = acquisitions;
            this.IpoDate = ipoDate;
            this.FundingRounds = fundingRounds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Financials" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Financials()
        {
        }

    }
}