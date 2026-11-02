
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RotateApiKeyResponse6
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.TeamManagement.JsonConverters.RotateApiKeyResponseCodeJsonConverter))]
        public global::Exa.TeamManagement.RotateApiKeyResponseCode? Code { get; set; }

        /// <summary>
        /// When the previous secret stops working. Present with `previous_secret_active`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousSecretExpiresAt")]
        public global::System.DateTime? PreviousSecretExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyResponse6" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="code"></param>
        /// <param name="previousSecretExpiresAt">
        /// When the previous secret stops working. Present with `previous_secret_active`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateApiKeyResponse6(
            string? error,
            global::Exa.TeamManagement.RotateApiKeyResponseCode? code,
            global::System.DateTime? previousSecretExpiresAt)
        {
            this.Error = error;
            this.Code = code;
            this.PreviousSecretExpiresAt = previousSecretExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyResponse6" /> class.
        /// </summary>
        public RotateApiKeyResponse6()
        {
        }

    }
}