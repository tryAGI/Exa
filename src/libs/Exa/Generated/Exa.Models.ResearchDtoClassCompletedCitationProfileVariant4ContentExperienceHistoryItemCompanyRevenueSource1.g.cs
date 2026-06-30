
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

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
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource1" /> class.
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="currency"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource1(
            double? amount,
            string? currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource1" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompanyRevenueSource1()
        {
        }

    }
}