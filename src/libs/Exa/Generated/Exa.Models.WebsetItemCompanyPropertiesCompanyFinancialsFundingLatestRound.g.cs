
#nullable enable

namespace Exa
{
    /// <summary>
    /// The latest funding round
    /// </summary>
    public sealed partial class WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound
    {
        /// <summary>
        /// The name of the funding round (e.g. Series A)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The date of the funding round
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// The amount raised in the funding round (USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the funding round (e.g. Series A)
        /// </param>
        /// <param name="date">
        /// The date of the funding round
        /// </param>
        /// <param name="amount">
        /// The amount raised in the funding round (USD)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound(
            string? name,
            string? date,
            double? amount)
        {
            this.Name = name;
            this.Date = date;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound" /> class.
        /// </summary>
        public WebsetItemCompanyPropertiesCompanyFinancialsFundingLatestRound()
        {
        }

    }
}