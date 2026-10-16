
#nullable enable

namespace Exa
{
    /// <summary>
    /// An accepted x402 payment requirement (scheme, network, amount, payTo, asset, maxTimeoutSeconds, and scheme-specific `extra` fields).
    /// </summary>
    public sealed partial class X402PaymentChallengeAccept
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}