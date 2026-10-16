
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetApiKeyUsageResponseCostBreakdownItem
    {
        /// <summary>
        /// Unique identifier for the price
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_id")]
        public string? PriceId { get; set; }

        /// <summary>
        /// Name of the price (e.g., "Neural Search", "Content Retrieval")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_name")]
        public string? PriceName { get; set; }

        /// <summary>
        /// Total quantity consumed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Cost in USD for this price type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_usd")]
        public double? AmountUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponseCostBreakdownItem" /> class.
        /// </summary>
        /// <param name="priceId">
        /// Unique identifier for the price
        /// </param>
        /// <param name="priceName">
        /// Name of the price (e.g., "Neural Search", "Content Retrieval")
        /// </param>
        /// <param name="quantity">
        /// Total quantity consumed
        /// </param>
        /// <param name="amountUsd">
        /// Cost in USD for this price type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeyUsageResponseCostBreakdownItem(
            string? priceId,
            string? priceName,
            double? quantity,
            double? amountUsd)
        {
            this.PriceId = priceId;
            this.PriceName = priceName;
            this.Quantity = quantity;
            this.AmountUsd = amountUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponseCostBreakdownItem" /> class.
        /// </summary>
        public GetApiKeyUsageResponseCostBreakdownItem()
        {
        }

    }
}