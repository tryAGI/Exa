
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RotateApiKeyResponseApiKey
    {
        /// <summary>
        /// Same value as `secret`, kept for backward compatibility. Use `publicId` to identify the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Stable identifier of the API key, unchanged by rotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicId")]
        public string? PublicId { get; set; }

        /// <summary>
        /// The new API key. Send it in the `x-api-key` header of Exa API requests and keep it in your secrets manager.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

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
        /// Spending budget for the API key, in cents
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
        public string? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// When the old secret stops working, or null if it was revoked immediately.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousSecretExpiresAt")]
        public global::System.DateTime? PreviousSecretExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyResponseApiKey" /> class.
        /// </summary>
        /// <param name="publicId">
        /// Stable identifier of the API key, unchanged by rotation.
        /// </param>
        /// <param name="secret">
        /// The new API key. Send it in the `x-api-key` header of Exa API requests and keep it in your secrets manager.
        /// </param>
        /// <param name="name"></param>
        /// <param name="rateLimit">
        /// Rate limit in requests per second
        /// </param>
        /// <param name="budgetCents">
        /// Spending budget for the API key, in cents
        /// </param>
        /// <param name="isOverBudget">
        /// Whether the API key is currently over its budget
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="createdAt"></param>
        /// <param name="previousSecretExpiresAt">
        /// When the old secret stops working, or null if it was revoked immediately.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateApiKeyResponseApiKey(
            string? publicId,
            string? secret,
            string? name,
            int? rateLimit,
            int? budgetCents,
            bool? isOverBudget,
            string? teamId,
            global::System.DateTime? createdAt,
            global::System.DateTime? previousSecretExpiresAt)
        {
            this.PublicId = publicId;
            this.Secret = secret;
            this.Name = name;
            this.RateLimit = rateLimit;
            this.BudgetCents = budgetCents;
            this.IsOverBudget = isOverBudget;
            this.TeamId = teamId;
            this.CreatedAt = createdAt;
            this.PreviousSecretExpiresAt = previousSecretExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyResponseApiKey" /> class.
        /// </summary>
        public RotateApiKeyResponseApiKey()
        {
        }

    }
}