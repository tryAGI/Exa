
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutput
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
        /// The full content text of the search result.<br/>
        /// Example: Abstract Large Language Models (LLMs) have recently demonstrated remarkable capabilities...
        /// </summary>
        /// <example>Abstract Large Language Models (LLMs) have recently demonstrated remarkable capabilities...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Array of highlights extracted from the search result content.<br/>
        /// Example: [Such requirements have limited their adoption...]
        /// </summary>
        /// <example>[Such requirements have limited their adoption...]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public global::System.Collections.Generic.IList<string>? Highlights { get; set; }

        /// <summary>
        /// Array of cosine similarity scores for each highlighted snippet.<br/>
        /// Example: [0.4600165784358978]
        /// </summary>
        /// <example>[0.4600165784358978]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightScores")]
        public global::System.Collections.Generic.IList<float>? HighlightScores { get; set; }

        /// <summary>
        /// Summary of the webpage.<br/>
        /// Example: This overview paper on Large Language Models (LLMs) highlights key developments...
        /// </summary>
        /// <example>This overview paper on Large Language Models (LLMs) highlights key developments...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Array of subpages for the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpages")]
        public global::System.Collections.Generic.IList<global::Exa.SearchResultOutputSubpage>? Subpages { get; set; }

        /// <summary>
        /// Structured entity data for company, person, or publication search results. Returned for supported entity-backed categories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Exa.OneOf<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>>? Entities { get; set; }

        /// <summary>
        /// Results from extras.<br/>
        /// Example: {"links":[]}
        /// </summary>
        /// <example>{"links":[]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public global::Exa.SearchResultOutputExtras? Extras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutput" /> class.
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
        /// <param name="text">
        /// The full content text of the search result.<br/>
        /// Example: Abstract Large Language Models (LLMs) have recently demonstrated remarkable capabilities...
        /// </param>
        /// <param name="highlights">
        /// Array of highlights extracted from the search result content.<br/>
        /// Example: [Such requirements have limited their adoption...]
        /// </param>
        /// <param name="highlightScores">
        /// Array of cosine similarity scores for each highlighted snippet.<br/>
        /// Example: [0.4600165784358978]
        /// </param>
        /// <param name="summary">
        /// Summary of the webpage.<br/>
        /// Example: This overview paper on Large Language Models (LLMs) highlights key developments...
        /// </param>
        /// <param name="subpages">
        /// Array of subpages for the search result.
        /// </param>
        /// <param name="entities">
        /// Structured entity data for company, person, or publication search results. Returned for supported entity-backed categories.
        /// </param>
        /// <param name="extras">
        /// Results from extras.<br/>
        /// Example: {"links":[]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutput(
            string title,
            string url,
            global::System.DateTime? publishedDate,
            string? author,
            string? id,
            string? image,
            string? favicon,
            string? text,
            global::System.Collections.Generic.IList<string>? highlights,
            global::System.Collections.Generic.IList<float>? highlightScores,
            string? summary,
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutputSubpage>? subpages,
            global::System.Collections.Generic.IList<global::Exa.OneOf<global::Exa.SearchResultOutputEntitieVariant1, global::Exa.SearchResultOutputEntitieVariant2, global::Exa.SearchResultOutputEntitieVariant3>>? entities,
            global::Exa.SearchResultOutputExtras? extras)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PublishedDate = publishedDate;
            this.Author = author;
            this.Id = id;
            this.Image = image;
            this.Favicon = favicon;
            this.Text = text;
            this.Highlights = highlights;
            this.HighlightScores = highlightScores;
            this.Summary = summary;
            this.Subpages = subpages;
            this.Entities = entities;
            this.Extras = extras;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutput" /> class.
        /// </summary>
        public SearchResultOutput()
        {
        }

    }
}