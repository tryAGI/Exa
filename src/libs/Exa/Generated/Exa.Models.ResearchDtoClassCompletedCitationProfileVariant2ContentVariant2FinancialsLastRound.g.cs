
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRound
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRoundAmount? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valuation")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRoundValuation? Valuation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("investors")]
        public global::System.Collections.Generic.IList<string>? Investors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_investors")]
        public double? NumInvestors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRound" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="amount"></param>
        /// <param name="valuation"></param>
        /// <param name="investors"></param>
        /// <param name="numInvestors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRound(
            string? name,
            string? date,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRoundAmount? amount,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRoundValuation? valuation,
            global::System.Collections.Generic.IList<string>? investors,
            double? numInvestors)
        {
            this.Name = name;
            this.Date = date;
            this.Amount = amount;
            this.Valuation = valuation;
            this.Investors = investors;
            this.NumInvestors = numInvestors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRound" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2FinancialsLastRound()
        {
        }

    }
}