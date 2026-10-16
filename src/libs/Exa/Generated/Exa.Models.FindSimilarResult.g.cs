
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FindSimilarResult
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
        /// The full content text of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Array of highlights extracted from the search result content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public global::System.Collections.Generic.IList<string>? Highlights { get; set; }

        /// <summary>
        /// Array of cosine similarity scores for each highlighted snippet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightScores")]
        public global::System.Collections.Generic.IList<float>? HighlightScores { get; set; }

        /// <summary>
        /// Summary of the webpage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Array of subpages for the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpages")]
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultSubpage>? Subpages { get; set; }

        /// <summary>
        /// Structured entity data for company, person, publication, or product search results. Returned for supported entity-backed categories and for product listing pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::Exa.FindSimilarResultEntitie>? Entities { get; set; }

        /// <summary>
        /// Results from extras. Each field is returned only when requested via contents.extras.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extras")]
        public global::Exa.FindSimilarResultExtras? Extras { get; set; }

        /// <summary>
        /// Similarity score between the source url and the result. Higher values mean more similar; the scale is not normalized, so compare scores only within a single response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResult" /> class.
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
        /// <param name="text">
        /// The full content text of the search result.
        /// </param>
        /// <param name="highlights">
        /// Array of highlights extracted from the search result content.
        /// </param>
        /// <param name="highlightScores">
        /// Array of cosine similarity scores for each highlighted snippet.
        /// </param>
        /// <param name="summary">
        /// Summary of the webpage.
        /// </param>
        /// <param name="subpages">
        /// Array of subpages for the search result.
        /// </param>
        /// <param name="entities">
        /// Structured entity data for company, person, publication, or product search results. Returned for supported entity-backed categories and for product listing pages.
        /// </param>
        /// <param name="extras">
        /// Results from extras. Each field is returned only when requested via contents.extras.
        /// </param>
        /// <param name="score">
        /// Similarity score between the source url and the result. Higher values mean more similar; the scale is not normalized, so compare scores only within a single response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarResult(
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
            global::System.Collections.Generic.IList<global::Exa.FindSimilarResultSubpage>? subpages,
            global::System.Collections.Generic.IList<global::Exa.FindSimilarResultEntitie>? entities,
            global::Exa.FindSimilarResultExtras? extras,
            float? score)
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
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResult" /> class.
        /// </summary>
        public FindSimilarResult()
        {
        }

    }
}