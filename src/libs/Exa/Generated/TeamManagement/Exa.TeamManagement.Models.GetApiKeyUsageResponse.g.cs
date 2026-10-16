
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetApiKeyUsageResponse
    {
        /// <summary>
        /// The unique identifier of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The API key ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public global::System.Guid? ApiKeyId { get; set; }

        /// <summary>
        /// The name of the API key
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_name")]
        public string? ApiKeyName { get; set; }

        /// <summary>
        /// The team ID this key belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public global::System.Guid? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        public global::Exa.TeamManagement.GetApiKeyUsageResponsePeriod? Period { get; set; }

        /// <summary>
        /// Total cost in USD for the period<br/>
        /// Example: 45.67
        /// </summary>
        /// <example>45.67</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost_usd")]
        public double? TotalCostUsd { get; set; }

        /// <summary>
        /// Breakdown of costs by price type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_breakdown")]
        public global::System.Collections.Generic.IList<global::Exa.TeamManagement.GetApiKeyUsageResponseCostBreakdownItem>? CostBreakdown { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Exa.TeamManagement.GetApiKeyUsageResponseMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the API key.
        /// </param>
        /// <param name="apiKeyId">
        /// The API key ID.
        /// </param>
        /// <param name="apiKeyName">
        /// The name of the API key
        /// </param>
        /// <param name="teamId">
        /// The team ID this key belongs to
        /// </param>
        /// <param name="period"></param>
        /// <param name="totalCostUsd">
        /// Total cost in USD for the period<br/>
        /// Example: 45.67
        /// </param>
        /// <param name="costBreakdown">
        /// Breakdown of costs by price type
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeyUsageResponse(
            string? id,
            global::System.Guid? apiKeyId,
            string? apiKeyName,
            global::System.Guid? teamId,
            global::Exa.TeamManagement.GetApiKeyUsageResponsePeriod? period,
            double? totalCostUsd,
            global::System.Collections.Generic.IList<global::Exa.TeamManagement.GetApiKeyUsageResponseCostBreakdownItem>? costBreakdown,
            global::Exa.TeamManagement.GetApiKeyUsageResponseMetadata? metadata)
        {
            this.Id = id;
            this.ApiKeyId = apiKeyId;
            this.ApiKeyName = apiKeyName;
            this.TeamId = teamId;
            this.Period = period;
            this.TotalCostUsd = totalCostUsd;
            this.CostBreakdown = costBreakdown;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponse" /> class.
        /// </summary>
        public GetApiKeyUsageResponse()
        {
        }

    }
}