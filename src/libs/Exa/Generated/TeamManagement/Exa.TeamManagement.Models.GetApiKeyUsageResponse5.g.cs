
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetApiKeyUsageResponse5
    {
        /// <summary>
        /// Example: Failed to fetch usage data. Please try again later.
        /// </summary>
        /// <example>Failed to fetch usage data. Please try again later.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponse5" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Failed to fetch usage data. Please try again later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetApiKeyUsageResponse5(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiKeyUsageResponse5" /> class.
        /// </summary>
        public GetApiKeyUsageResponse5()
        {
        }

    }
}