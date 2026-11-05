
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTeamCreditsResponse
    {
        /// <summary>
        /// Remaining prepaid credits in USD, including granted credits. For a team billed through its organization's billing team, the billing team's credits. Requests are refused once it reaches 0 unless overage is enabled for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_usd")]
        public double? CreditsUsd { get; set; }

        /// <summary>
        /// Credits with an expiry date, soonest first. Usage draws from the soonest-expiring credits first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiring_credits")]
        public global::System.Collections.Generic.IList<global::Exa.TeamManagement.GetTeamCreditsResponseExpiringCredit>? ExpiringCredits { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Exa.TeamManagement.GetTeamCreditsResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamCreditsResponse" /> class.
        /// </summary>
        /// <param name="creditsUsd">
        /// Remaining prepaid credits in USD, including granted credits. For a team billed through its organization's billing team, the billing team's credits. Requests are refused once it reaches 0 unless overage is enabled for the team.
        /// </param>
        /// <param name="expiringCredits">
        /// Credits with an expiry date, soonest first. Usage draws from the soonest-expiring credits first.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamCreditsResponse(
            double? creditsUsd,
            global::System.Collections.Generic.IList<global::Exa.TeamManagement.GetTeamCreditsResponseExpiringCredit>? expiringCredits,
            global::Exa.TeamManagement.GetTeamCreditsResponseMetadata? metadata)
        {
            this.CreditsUsd = creditsUsd;
            this.ExpiringCredits = expiringCredits;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamCreditsResponse" /> class.
        /// </summary>
        public GetTeamCreditsResponse()
        {
        }

    }
}