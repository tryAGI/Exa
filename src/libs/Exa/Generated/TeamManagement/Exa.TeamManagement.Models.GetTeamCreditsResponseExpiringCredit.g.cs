
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTeamCreditsResponseExpiringCredit
    {
        /// <summary>
        /// Credits left in USD that expire at `expires_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_usd")]
        public double? AmountUsd { get; set; }

        /// <summary>
        /// When these credits expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamCreditsResponseExpiringCredit" /> class.
        /// </summary>
        /// <param name="amountUsd">
        /// Credits left in USD that expire at `expires_at`.
        /// </param>
        /// <param name="expiresAt">
        /// When these credits expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamCreditsResponseExpiringCredit(
            double? amountUsd,
            global::System.DateTime? expiresAt)
        {
            this.AmountUsd = amountUsd;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamCreditsResponseExpiringCredit" /> class.
        /// </summary>
        public GetTeamCreditsResponseExpiringCredit()
        {
        }

    }
}