
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateApiKeyRequest
    {
        /// <summary>
        /// Optional name for the API key<br/>
        /// Example: Production API Key
        /// </summary>
        /// <example>Production API Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional rate limit for the API key (requests per second)<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public int? RateLimit { get; set; }

        /// <summary>
        /// Optional spending budget for the API key in the team's current billing period, in cents. It resets when the next billing period starts. Set to null to remove the budget.<br/>
        /// Example: 5000
        /// </summary>
        /// <example>5000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("budgetCents")]
        public int? BudgetCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional name for the API key<br/>
        /// Example: Production API Key
        /// </param>
        /// <param name="rateLimit">
        /// Optional rate limit for the API key (requests per second)<br/>
        /// Example: 1000
        /// </param>
        /// <param name="budgetCents">
        /// Optional spending budget for the API key in the team's current billing period, in cents. It resets when the next billing period starts. Set to null to remove the budget.<br/>
        /// Example: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateApiKeyRequest(
            string? name,
            int? rateLimit,
            int? budgetCents)
        {
            this.Name = name;
            this.RateLimit = rateLimit;
            this.BudgetCents = budgetCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateApiKeyRequest" /> class.
        /// </summary>
        public CreateApiKeyRequest()
        {
        }

    }
}