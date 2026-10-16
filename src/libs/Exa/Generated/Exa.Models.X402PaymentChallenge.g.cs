
#nullable enable

namespace Exa
{
    /// <summary>
    /// x402 payment challenge: the standard error envelope extended with x402 payment metadata.
    /// </summary>
    public sealed partial class X402PaymentChallenge
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Human-readable message describing the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Machine-readable error tag identifying the failure. The set of tags is open-ended: new tags may be added at any time, so treat unrecognized tags as a generic error of the response's HTTP status. Known tags are listed as examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Version of the x402 protocol used to build this challenge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x402Version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X402Version { get; set; }

        /// <summary>
        /// The priced resource this challenge applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.X402PaymentChallengeResource Resource { get; set; }

        /// <summary>
        /// Payment requirements the server accepts, one per supported rail.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Accepts { get; set; }

        /// <summary>
        /// Optional x402 protocol extensions (e.g. Bazaar or AgentKit discovery metadata).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public object? Extensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="X402PaymentChallenge" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="error">
        /// Human-readable message describing the error.
        /// </param>
        /// <param name="tag">
        /// Machine-readable error tag identifying the failure. The set of tags is open-ended: new tags may be added at any time, so treat unrecognized tags as a generic error of the response's HTTP status. Known tags are listed as examples.
        /// </param>
        /// <param name="x402Version">
        /// Version of the x402 protocol used to build this challenge.
        /// </param>
        /// <param name="resource">
        /// The priced resource this challenge applies to.
        /// </param>
        /// <param name="accepts">
        /// Payment requirements the server accepts, one per supported rail.
        /// </param>
        /// <param name="extensions">
        /// Optional x402 protocol extensions (e.g. Bazaar or AgentKit discovery metadata).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public X402PaymentChallenge(
            string requestId,
            string error,
            string tag,
            double x402Version,
            global::Exa.X402PaymentChallengeResource resource,
            global::System.Collections.Generic.IList<object> accepts,
            object? extensions)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.X402Version = x402Version;
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
            this.Accepts = accepts ?? throw new global::System.ArgumentNullException(nameof(accepts));
            this.Extensions = extensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="X402PaymentChallenge" /> class.
        /// </summary>
        public X402PaymentChallenge()
        {
        }

    }
}