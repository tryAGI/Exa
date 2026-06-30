
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesFinancialsFundingLatestRound2
    {
        /// <summary>
        /// Funding round name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Funding round date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Funding round amount in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesFinancialsFundingLatestRound2" /> class.
        /// </summary>
        /// <param name="name">
        /// Funding round name.
        /// </param>
        /// <param name="date">
        /// Funding round date.
        /// </param>
        /// <param name="amount">
        /// Funding round amount in USD.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesFinancialsFundingLatestRound2(
            string? name,
            string? date,
            double? amount)
        {
            this.Name = name;
            this.Date = date;
            this.Amount = amount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesFinancialsFundingLatestRound2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesFinancialsFundingLatestRound2()
        {
        }

    }
}