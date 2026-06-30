
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revenue")]
        public double? Revenue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gross_profit")]
        public double? GrossProfit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_income")]
        public double? OperatingIncome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_income")]
        public double? NetIncome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ebitda")]
        public double? Ebitda { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eps")]
        public double? Eps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gross_margin")]
        public double? GrossMargin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_margin")]
        public double? OperatingMargin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_margin")]
        public double? NetMargin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement" /> class.
        /// </summary>
        /// <param name="period"></param>
        /// <param name="endDate"></param>
        /// <param name="revenue"></param>
        /// <param name="grossProfit"></param>
        /// <param name="operatingIncome"></param>
        /// <param name="netIncome"></param>
        /// <param name="ebitda"></param>
        /// <param name="eps"></param>
        /// <param name="grossMargin"></param>
        /// <param name="operatingMargin"></param>
        /// <param name="netMargin"></param>
        /// <param name="currency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement(
            string period,
            string endDate,
            double? revenue,
            double? grossProfit,
            double? operatingIncome,
            double? netIncome,
            double? ebitda,
            double? eps,
            double? grossMargin,
            double? operatingMargin,
            double? netMargin,
            string? currency)
        {
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.EndDate = endDate ?? throw new global::System.ArgumentNullException(nameof(endDate));
            this.Revenue = revenue;
            this.GrossProfit = grossProfit;
            this.OperatingIncome = operatingIncome;
            this.NetIncome = netIncome;
            this.Ebitda = ebitda;
            this.Eps = eps;
            this.GrossMargin = grossMargin;
            this.OperatingMargin = operatingMargin;
            this.NetMargin = netMargin;
            this.Currency = currency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsIncomeStatement()
        {
        }

    }
}