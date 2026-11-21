
#nullable enable

namespace Exa
{
    /// <summary>
    /// What the search cost, in dollars. Returned once the search has finished, for teams on the pay-as-you-go plan, which is charged for what each search uses. Omitted for teams on other plans. `emails`, `phoneNumbers` and `total` keep growing after the search has finished, as enrichments find contact details for its items. They are final once the Webset's status is `idle`, and grow again if an enrichment is added or changed. This response value is not an invoice record.
    /// </summary>
    public sealed partial class WebsetSearchCostDollars
    {
        /// <summary>
        /// Total cost of the search in dollars, including the emails and phone numbers found for its items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Cost of the model usage the search needed, in dollars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentCompute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AgentCompute { get; set; }

        /// <summary>
        /// Cost of the Exa searches the search ran, in dollars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Search { get; set; }

        /// <summary>
        /// Cost of the emails that enrichments found for the items the search added, in dollars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Emails { get; set; }

        /// <summary>
        /// Cost of the phone numbers that enrichments found for the items the search added, in dollars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phoneNumbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PhoneNumbers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchCostDollars" /> class.
        /// </summary>
        /// <param name="total">
        /// Total cost of the search in dollars, including the emails and phone numbers found for its items.
        /// </param>
        /// <param name="agentCompute">
        /// Cost of the model usage the search needed, in dollars.
        /// </param>
        /// <param name="search">
        /// Cost of the Exa searches the search ran, in dollars.
        /// </param>
        /// <param name="emails">
        /// Cost of the emails that enrichments found for the items the search added, in dollars.
        /// </param>
        /// <param name="phoneNumbers">
        /// Cost of the phone numbers that enrichments found for the items the search added, in dollars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetSearchCostDollars(
            double total,
            double agentCompute,
            double search,
            double emails,
            double phoneNumbers)
        {
            this.Total = total;
            this.AgentCompute = agentCompute;
            this.Search = search;
            this.Emails = emails;
            this.PhoneNumbers = phoneNumbers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetSearchCostDollars" /> class.
        /// </summary>
        public WebsetSearchCostDollars()
        {
        }

    }
}