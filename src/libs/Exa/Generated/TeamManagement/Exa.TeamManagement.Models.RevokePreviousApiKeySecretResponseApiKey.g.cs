
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RevokePreviousApiKeySecretResponseApiKey
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publicId")]
        public string? PublicId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousSecretExpiresAt")]
        public object? PreviousSecretExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokePreviousApiKeySecretResponseApiKey" /> class.
        /// </summary>
        /// <param name="publicId"></param>
        /// <param name="previousSecretExpiresAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevokePreviousApiKeySecretResponseApiKey(
            string? publicId,
            object? previousSecretExpiresAt)
        {
            this.PublicId = publicId;
            this.PreviousSecretExpiresAt = previousSecretExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokePreviousApiKeySecretResponseApiKey" /> class.
        /// </summary>
        public RevokePreviousApiKeySecretResponseApiKey()
        {
        }

    }
}