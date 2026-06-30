
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Financials
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue_annual")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueAnnual? RevenueAnnual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue_range")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueRange? RevenueRange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue_growth")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueGrowth? RevenueGrowth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profitable")]
        public bool? Profitable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("income_statements")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement>? IncomeStatements { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ipo_date")]
        public string? IpoDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("market_cap")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsMarketCap? MarketCap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stock_price")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsStockPrice? StockPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stock_history")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsStockHistoryItem>? StockHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_funding")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsTotalFunding? TotalFunding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("funding_rounds")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsFundingRound>? FundingRounds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_round")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsLastRound? LastRound { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acquisitions")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitions? Acquisitions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Financials" /> class.
        /// </summary>
        /// <param name="revenueAnnual"></param>
        /// <param name="revenueRange"></param>
        /// <param name="revenueGrowth"></param>
        /// <param name="profitable"></param>
        /// <param name="incomeStatements"></param>
        /// <param name="ipoDate"></param>
        /// <param name="marketCap"></param>
        /// <param name="stockPrice"></param>
        /// <param name="stockHistory"></param>
        /// <param name="totalFunding"></param>
        /// <param name="fundingRounds"></param>
        /// <param name="lastRound"></param>
        /// <param name="acquisitions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Financials(
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueAnnual? revenueAnnual,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueRange? revenueRange,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsRevenueGrowth? revenueGrowth,
            bool? profitable,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement>? incomeStatements,
            string? ipoDate,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsMarketCap? marketCap,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsStockPrice? stockPrice,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsStockHistoryItem>? stockHistory,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsTotalFunding? totalFunding,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsFundingRound>? fundingRounds,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsLastRound? lastRound,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitions? acquisitions)
        {
            this.RevenueAnnual = revenueAnnual;
            this.RevenueRange = revenueRange;
            this.RevenueGrowth = revenueGrowth;
            this.Profitable = profitable;
            this.IncomeStatements = incomeStatements;
            this.IpoDate = ipoDate;
            this.MarketCap = marketCap;
            this.StockPrice = stockPrice;
            this.StockHistory = stockHistory;
            this.TotalFunding = totalFunding;
            this.FundingRounds = fundingRounds;
            this.LastRound = lastRound;
            this.Acquisitions = acquisitions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Financials" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Financials()
        {
        }

    }
}