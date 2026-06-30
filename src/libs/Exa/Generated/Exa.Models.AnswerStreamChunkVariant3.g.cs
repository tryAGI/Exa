
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerStreamChunkVariant3
    {
        /// <summary>
        /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.CostDollarsOutput CostDollars { get; set; }

        /// <summary>
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamChunkVariant3" /> class.
        /// </summary>
        /// <param name="costDollars">
        /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerStreamChunkVariant3(
            global::Exa.CostDollarsOutput costDollars,
            string? requestId)
        {
            this.CostDollars = costDollars ?? throw new global::System.ArgumentNullException(nameof(costDollars));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamChunkVariant3" /> class.
        /// </summary>
        public AnswerStreamChunkVariant3()
        {
        }

    }
}