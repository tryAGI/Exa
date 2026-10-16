
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchResultOutputExtrasRichLink
    {
        /// <summary>
        /// The URL of the link.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The anchor text of the link, when the page provides one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        public string? Anchor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputExtrasRichLink" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the link.
        /// </param>
        /// <param name="anchor">
        /// The anchor text of the link, when the page provides one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputExtrasRichLink(
            string url,
            string? anchor)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Anchor = anchor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputExtrasRichLink" /> class.
        /// </summary>
        public SearchResultOutputExtrasRichLink()
        {
        }

    }
}