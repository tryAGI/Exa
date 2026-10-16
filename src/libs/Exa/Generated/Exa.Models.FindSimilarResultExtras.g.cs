
#nullable enable

namespace Exa
{
    /// <summary>
    /// Results from extras. Each field is returned only when requested via contents.extras.
    /// </summary>
    public sealed partial class FindSimilarResultExtras
    {
        /// <summary>
        /// Array of links from the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<string>? Links { get; set; }

        /// <summary>
        /// Array of image URLs from the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageLinks")]
        public global::System.Collections.Generic.IList<string>? ImageLinks { get; set; }

        /// <summary>
        /// Array of images with their alt text, in the order the images appear on the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("richImageLinks")]
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichImageLink>? RichImageLinks { get; set; }

        /// <summary>
        /// Array of links with their anchor text, in the order they appear on the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("richLinks")]
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichLink>? RichLinks { get; set; }

        /// <summary>
        /// Array of code blocks from the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeBlocks")]
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasCodeBlock>? CodeBlocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResultExtras" /> class.
        /// </summary>
        /// <param name="links">
        /// Array of links from the search result.
        /// </param>
        /// <param name="imageLinks">
        /// Array of image URLs from the search result.
        /// </param>
        /// <param name="richImageLinks">
        /// Array of images with their alt text, in the order the images appear on the page.
        /// </param>
        /// <param name="richLinks">
        /// Array of links with their anchor text, in the order they appear on the page.
        /// </param>
        /// <param name="codeBlocks">
        /// Array of code blocks from the search result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarResultExtras(
            global::System.Collections.Generic.IList<string>? links,
            global::System.Collections.Generic.IList<string>? imageLinks,
            global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichImageLink>? richImageLinks,
            global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasRichLink>? richLinks,
            global::System.Collections.Generic.IList<global::Exa.FindSimilarResultExtrasCodeBlock>? codeBlocks)
        {
            this.Links = links;
            this.ImageLinks = imageLinks;
            this.RichImageLinks = richImageLinks;
            this.RichLinks = richLinks;
            this.CodeBlocks = codeBlocks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResultExtras" /> class.
        /// </summary>
        public FindSimilarResultExtras()
        {
        }

    }
}