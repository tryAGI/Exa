
#nullable enable

namespace Exa
{
    /// <summary>
    /// Citation from research sources
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedDate")]
        public string? PublishedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public global::System.Collections.Generic.IList<string>? Highlights { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlightScores")]
        public global::System.Collections.Generic.IList<double>? HighlightScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationLink>? Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subpages")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationSubpage>? Subpages { get; set; }

        /// <summary>
        /// URL of the image associated with the result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// URL of the favicon associated with the result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// The profile related to the search result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ProfileJsonConverter))]
        public global::Exa.Profile? Profile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationCategoryJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationCategory? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationSourceJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitation" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="url"></param>
        /// <param name="title"></param>
        /// <param name="publishedDate"></param>
        /// <param name="author"></param>
        /// <param name="score"></param>
        /// <param name="text"></param>
        /// <param name="highlights"></param>
        /// <param name="highlightScores"></param>
        /// <param name="summary"></param>
        /// <param name="links"></param>
        /// <param name="subpages"></param>
        /// <param name="image">
        /// URL of the image associated with the result
        /// </param>
        /// <param name="favicon">
        /// URL of the favicon associated with the result
        /// </param>
        /// <param name="description"></param>
        /// <param name="subtitle"></param>
        /// <param name="snippet"></param>
        /// <param name="profile">
        /// The profile related to the search result
        /// </param>
        /// <param name="category"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitation(
            string id,
            string url,
            string title,
            string? publishedDate,
            string? author,
            double? score,
            string? text,
            global::System.Collections.Generic.IList<string>? highlights,
            global::System.Collections.Generic.IList<double>? highlightScores,
            string? summary,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationLink>? links,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationSubpage>? subpages,
            string? image,
            string? favicon,
            string? description,
            string? subtitle,
            string? snippet,
            global::Exa.Profile? profile,
            global::Exa.ResearchDtoClassCompletedCitationCategory? category,
            global::Exa.ResearchDtoClassCompletedCitationSource? source)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.PublishedDate = publishedDate;
            this.Author = author;
            this.Score = score;
            this.Text = text;
            this.Highlights = highlights;
            this.HighlightScores = highlightScores;
            this.Summary = summary;
            this.Links = links;
            this.Subpages = subpages;
            this.Image = image;
            this.Favicon = favicon;
            this.Description = description;
            this.Subtitle = subtitle;
            this.Snippet = snippet;
            this.Profile = profile;
            this.Category = category;
            this.Source = source;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitation" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitation()
        {
        }

    }
}