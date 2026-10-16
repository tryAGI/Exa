
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchStreamGroundingChunkOutputChoiceDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamGroundingChunkOutputChoiceDelta" /> class.
        /// </summary>
        /// <param name="role"></param>
        /// <param name="content"></param>
        /// <param name="citations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamGroundingChunkOutputChoiceDelta(
            string? role,
            string? content,
            global::System.Collections.Generic.IList<global::Exa.SearchStreamGroundingChunkOutputChoiceDeltaCitation>? citations)
        {
            this.Role = role;
            this.Content = content;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamGroundingChunkOutputChoiceDelta" /> class.
        /// </summary>
        public SearchStreamGroundingChunkOutputChoiceDelta()
        {
        }

    }
}