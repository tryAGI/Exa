
#nullable enable

namespace Exa
{
    /// <summary>
    /// Extra parameters to pass.
    /// </summary>
    public sealed partial class ContentsRequestExtras2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public int? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageLinks")]
        public int? ImageLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("richImageLinks")]
        public int? RichImageLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("richLinks")]
        public int? RichLinks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codeBlocks")]
        public int? CodeBlocks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestExtras2" /> class.
        /// </summary>
        /// <param name="links"></param>
        /// <param name="imageLinks"></param>
        /// <param name="richImageLinks"></param>
        /// <param name="richLinks"></param>
        /// <param name="codeBlocks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestExtras2(
            int? links,
            int? imageLinks,
            int? richImageLinks,
            int? richLinks,
            int? codeBlocks)
        {
            this.Links = links;
            this.ImageLinks = imageLinks;
            this.RichImageLinks = richImageLinks;
            this.RichLinks = richLinks;
            this.CodeBlocks = codeBlocks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestExtras2" /> class.
        /// </summary>
        public ContentsRequestExtras2()
        {
        }

    }
}