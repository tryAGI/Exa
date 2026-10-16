
#nullable enable

namespace Exa
{
    /// <summary>
    /// The priced resource this challenge applies to.
    /// </summary>
    public sealed partial class X402PaymentChallengeResource
    {
        /// <summary>
        /// URL of the priced resource being requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Human-readable resource description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// MIME type of the priced resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="X402PaymentChallengeResource" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the priced resource being requested.
        /// </param>
        /// <param name="description">
        /// Human-readable resource description.
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the priced resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public X402PaymentChallengeResource(
            string url,
            string description,
            string mimeType)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="X402PaymentChallengeResource" /> class.
        /// </summary>
        public X402PaymentChallengeResource()
        {
        }

    }
}