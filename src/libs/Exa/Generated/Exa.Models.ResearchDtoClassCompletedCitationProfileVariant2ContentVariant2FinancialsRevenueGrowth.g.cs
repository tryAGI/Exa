
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueGrowth
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Current { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly")]
        public double? Monthly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_pct")]
        public double? MonthlyPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quarterly")]
        public double? Quarterly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quarterly_pct")]
        public double? QuarterlyPct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yearly")]
        public double? Yearly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yearly_pct")]
        public double? YearlyPct { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueGrowth" /> class.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="monthly"></param>
        /// <param name="monthlyPct"></param>
        /// <param name="quarterly"></param>
        /// <param name="quarterlyPct"></param>
        /// <param name="yearly"></param>
        /// <param name="yearlyPct"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueGrowth(
            double current,
            double? monthly,
            double? monthlyPct,
            double? quarterly,
            double? quarterlyPct,
            double? yearly,
            double? yearlyPct)
        {
            this.Current = current;
            this.Monthly = monthly;
            this.MonthlyPct = monthlyPct;
            this.Quarterly = quarterly;
            this.QuarterlyPct = quarterlyPct;
            this.Yearly = yearly;
            this.YearlyPct = yearlyPct;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueGrowth" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsRevenueGrowth()
        {
        }

    }
}