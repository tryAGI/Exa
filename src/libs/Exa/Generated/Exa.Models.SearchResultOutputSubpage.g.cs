
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchResultOutputSubpage
    {
        /// <summary>
        /// The title of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The URL of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// An estimate of the creation date, from parsing HTML content. Format is YYYY-MM-DD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedDate")]
        public global::System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// If available, the author of the content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// The temporary ID for the document. Useful for the /contents endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The URL of an image associated with the search result, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// The URL of the favicon for the search result's domain.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputSubpage" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the search result.
        /// </param>
        /// <param name="url">
        /// The URL of the search result.
        /// </param>
        /// <param name="publishedDate">
        /// An estimate of the creation date, from parsing HTML content. Format is YYYY-MM-DD.
        /// </param>
        /// <param name="author">
        /// If available, the author of the content.
        /// </param>
        /// <param name="id">
        /// The temporary ID for the document. Useful for the /contents endpoint.
        /// </param>
        /// <param name="image">
        /// The URL of an image associated with the search result, if available.
        /// </param>
        /// <param name="favicon">
        /// The URL of the favicon for the search result's domain.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputSubpage(
            string title,
            string url,
            global::System.DateTime? publishedDate,
            string? author,
            string? id,
            string? image,
            string? favicon)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PublishedDate = publishedDate;
            this.Author = author;
            this.Id = id;
            this.Image = image;
            this.Favicon = favicon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputSubpage" /> class.
        /// </summary>
        public SearchResultOutputSubpage()
        {
        }

    }
}