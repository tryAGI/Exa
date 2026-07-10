
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRoundAmount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Default Value: USD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRoundAmount" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="currency">
        /// Default Value: USD
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRoundAmount(
            double value,
            string? currency)
        {
            this.Value = value;
            this.Currency = currency;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRoundAmount" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsFundingRoundAmount()
        {
        }

    }
}