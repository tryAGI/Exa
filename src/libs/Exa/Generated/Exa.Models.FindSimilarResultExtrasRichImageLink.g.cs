
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FindSimilarResultExtrasRichImageLink
    {
        /// <summary>
        /// The URL of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The alt text of the image, when the page provides one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alt")]
        public string? Alt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResultExtrasRichImageLink" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the image.
        /// </param>
        /// <param name="alt">
        /// The alt text of the image, when the page provides one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarResultExtrasRichImageLink(
            string url,
            string? alt)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Alt = alt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResultExtrasRichImageLink" /> class.
        /// </summary>
        public FindSimilarResultExtrasRichImageLink()
        {
        }

    }
}