
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RevokePreviousApiKeySecretResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public global::Exa.TeamManagement.RevokePreviousApiKeySecretResponseApiKey? ApiKey { get; set; }

        /// <summary>
        /// Whether a previous secret was revoked by this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoked")]
        public bool? Revoked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokePreviousApiKeySecretResponse" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="revoked">
        /// Whether a previous secret was revoked by this request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevokePreviousApiKeySecretResponse(
            global::Exa.TeamManagement.RevokePreviousApiKeySecretResponseApiKey? apiKey,
            bool? revoked)
        {
            this.ApiKey = apiKey;
            this.Revoked = revoked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokePreviousApiKeySecretResponse" /> class.
        /// </summary>
        public RevokePreviousApiKeySecretResponse()
        {
        }

    }
}