
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisitionAmount? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deal_type")]
        public string? DealType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition" /> class.
        /// </summary>
        /// <param name="companyName"></param>
        /// <param name="date"></param>
        /// <param name="amount"></param>
        /// <param name="dealType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition(
            string companyName,
            string? date,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisitionAmount? amount,
            string? dealType)
        {
            this.CompanyName = companyName ?? throw new global::System.ArgumentNullException(nameof(companyName));
            this.Date = date;
            this.Amount = amount;
            this.DealType = dealType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition()
        {
        }

    }
}