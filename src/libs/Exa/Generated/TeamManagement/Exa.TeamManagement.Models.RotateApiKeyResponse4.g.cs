
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RotateApiKeyResponse4
    {
        /// <summary>
        /// Example: This key is managed by an integration and cannot be rotated
        /// </summary>
        /// <example>This key is managed by an integration and cannot be rotated</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyResponse4" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: This key is managed by an integration and cannot be rotated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RotateApiKeyResponse4(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RotateApiKeyResponse4" /> class.
        /// </summary>
        public RotateApiKeyResponse4()
        {
        }

    }
}