
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListApiKeysResponseVariant1ApiKey
    {
        /// <summary>
        /// The API key's secret. Despite the field name it is not an identifier; use `publicId` to identify the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Stable identifier of the API key. It does not change when the key is rotated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicId")]
        public string? PublicId { get; set; }

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
        /// When the secret replaced by the last rotation stops working, or null if it no longer works.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousSecretExpiresAt")]
        public global::System.DateTime? PreviousSecretExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponseVariant1ApiKey" /> class.
        /// </summary>
        /// <param name="id">
        /// The API key's secret. Despite the field name it is not an identifier; use `publicId` to identify the key.
        /// </param>
        /// <param name="publicId">
        /// Stable identifier of the API key. It does not change when the key is rotated.
        /// </param>
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
        /// <param name="previousSecretExpiresAt">
        /// When the secret replaced by the last rotation stops working, or null if it no longer works.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListApiKeysResponseVariant1ApiKey(
            global::System.Guid? id,
            string? publicId,
            string? name,
            int? rateLimit,
            int? budgetCents,
            bool? isOverBudget,
            global::System.DateTime? previousSecretExpiresAt)
        {
            this.Id = id;
            this.PublicId = publicId;
            this.Name = name;
            this.RateLimit = rateLimit;
            this.BudgetCents = budgetCents;
            this.IsOverBudget = isOverBudget;
            this.PreviousSecretExpiresAt = previousSecretExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListApiKeysResponseVariant1ApiKey" /> class.
        /// </summary>
        public ListApiKeysResponseVariant1ApiKey()
        {
        }

    }
}