
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerStreamCostChunkOutput
    {
        /// <summary>
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CostDollarsOutput CostDollars { get; set; }

        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamCostChunkOutput" /> class.
        /// </summary>
        /// <param name="costDollars">
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerStreamCostChunkOutput(
            global::Exa.CostDollarsOutput costDollars,
            string? requestId)
        {
            this.CostDollars = costDollars ?? throw new global::System.ArgumentNullException(nameof(costDollars));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamCostChunkOutput" /> class.
        /// </summary>
        public AnswerStreamCostChunkOutput()
        {
        }

    }
}