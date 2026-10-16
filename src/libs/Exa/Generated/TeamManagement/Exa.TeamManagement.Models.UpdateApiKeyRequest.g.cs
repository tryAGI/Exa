
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateApiKeyRequest
    {
        /// <summary>
        /// Optional new name for the API key<br/>
        /// Example: Updated Production Key
        /// </summary>
        /// <example>Updated Production Key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional new rate limit for the API key (requests per second)<br/>
        /// Example: 2000
        /// </summary>
        /// <example>2000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public int? RateLimit { get; set; }

        /// <summary>
        /// Optional new spending budget for the API key in the team's current billing period, in cents. It resets when the next billing period starts. Set to null to remove the budget.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateApiKeyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Optional new name for the API key<br/>
        /// Example: Updated Production Key
        /// </param>
        /// <param name="rateLimit">
        /// Optional new rate limit for the API key (requests per second)<br/>
        /// Example: 2000
        /// </param>
        /// <param name="budgetCents">
        /// Optional new spending budget for the API key in the team's current billing period, in cents. It resets when the next billing period starts. Set to null to remove the budget.<br/>
        /// Example: 5000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateApiKeyRequest(
            string? name,
            int? rateLimit,
            int? budgetCents)
        {
            this.Name = name;
            this.RateLimit = rateLimit;
            this.BudgetCents = budgetCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateApiKeyRequest" /> class.
        /// </summary>
        public UpdateApiKeyRequest()
        {
        }

    }
}