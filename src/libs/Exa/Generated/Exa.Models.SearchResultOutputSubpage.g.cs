
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputSubpage
    {
        /// <summary>
        /// The title of the search result.<br/>
        /// Example: A Comprehensive Overview of Large Language Models
        /// </summary>
        /// <example>A Comprehensive Overview of Large Language Models</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The URL of the search result.<br/>
        /// Example: https://arxiv.org/pdf/2307.06435.pdf
        /// </summary>
        /// <example>https://arxiv.org/pdf/2307.06435.pdf</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// An estimate of the creation date, from parsing HTML content. Format is YYYY-MM-DD.<br/>
        /// Example: 2023-11-16 01:36:32.547000000 Z
        /// </summary>
        /// <example>2023-11-16 01:36:32.547000000 Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedDate")]
        public global::System.DateTime? PublishedDate { get; set; }

        /// <summary>
        /// If available, the author of the content.<br/>
        /// Example: Humza Naveed
        /// </summary>
        /// <example>Humza Naveed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// The temporary ID for the document. Useful for the /contents endpoint.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </summary>
        /// <example>https://arxiv.org/abs/2307.06435</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The URL of an image associated with the search result, if available.<br/>
        /// Example: https://arxiv.org/pdf/2307.06435.pdf/page_1.png
        /// </summary>
        /// <example>https://arxiv.org/pdf/2307.06435.pdf/page_1.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// The URL of the favicon for the search result's domain.<br/>
        /// Example: https://arxiv.org/favicon.ico
        /// </summary>
        /// <example>https://arxiv.org/favicon.ico</example>
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
        /// The title of the search result.<br/>
        /// Example: A Comprehensive Overview of Large Language Models
        /// </param>
        /// <param name="url">
        /// The URL of the search result.<br/>
        /// Example: https://arxiv.org/pdf/2307.06435.pdf
        /// </param>
        /// <param name="publishedDate">
        /// An estimate of the creation date, from parsing HTML content. Format is YYYY-MM-DD.<br/>
        /// Example: 2023-11-16 01:36:32.547000000 Z
        /// </param>
        /// <param name="author">
        /// If available, the author of the content.<br/>
        /// Example: Humza Naveed
        /// </param>
        /// <param name="id">
        /// The temporary ID for the document. Useful for the /contents endpoint.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </param>
        /// <param name="image">
        /// The URL of an image associated with the search result, if available.<br/>
        /// Example: https://arxiv.org/pdf/2307.06435.pdf/page_1.png
        /// </param>
        /// <param name="favicon">
        /// The URL of the favicon for the search result's domain.<br/>
        /// Example: https://arxiv.org/favicon.ico
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