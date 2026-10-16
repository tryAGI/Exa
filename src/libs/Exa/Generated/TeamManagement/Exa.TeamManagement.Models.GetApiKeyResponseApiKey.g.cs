
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetApiKeyResponseApiKey
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Rate limit in requests per second
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rateLimit")]
        public int? RateLimit { get; set; }

        /// <summary>
        /// Spending budget for the API key in the team's current billing period, in cents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("budgetCents")]
        public int? BudgetCents { get; set; }

        /// <summary>
        /// Whether the API key is currently over its budget
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isOverBudget")]
        public bool? IsOverBudget { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teamId")]
        public global::System.Guid? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyResponseApiKey" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="rateLimit">
        /// Rate limit in requests per second
        /// </param>
        /// <param name="budgetCents">
        /// Spending budget for the API key in the team's current billing period, in cents
        /// </param>
        /// <param name="isOverBudget">
        /// Whether the API key is currently over its budget
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeyResponseApiKey(
            global::System.Guid? id,
            string? name,
            int? rateLimit,
            int? budgetCents,
            bool? isOverBudget,
            global::System.Guid? teamId,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Name = name;
            this.RateLimit = rateLimit;
            this.BudgetCents = budgetCents;
            this.IsOverBudget = isOverBudget;
            this.TeamId = teamId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyResponseApiKey" /> class.
        /// </summary>
        public GetApiKeyResponseApiKey()
        {
        }

    }
}