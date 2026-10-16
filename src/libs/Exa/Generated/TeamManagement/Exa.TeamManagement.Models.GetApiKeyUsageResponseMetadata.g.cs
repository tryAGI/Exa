
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetApiKeyUsageResponseMetadata
    {
        /// <summary>
        /// When this report was generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at")]
        public global::System.DateTime? GeneratedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponseMetadata" /> class.
        /// </summary>
        /// <param name="generatedAt">
        /// When this report was generated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeyUsageResponseMetadata(
            global::System.DateTime? generatedAt)
        {
            this.GeneratedAt = generatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponseMetadata" /> class.
        /// </summary>
        public GetApiKeyUsageResponseMetadata()
        {
        }

    }
}