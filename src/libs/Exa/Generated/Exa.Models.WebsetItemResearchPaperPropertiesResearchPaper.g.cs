
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemResearchPaperPropertiesResearchPaper
    {
        /// <summary>
        /// The title of the research paper
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The author(s) of the research paper
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// The date and time the research paper was published
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedAt")]
        public string? PublishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemResearchPaperPropertiesResearchPaper" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the research paper
        /// </param>
        /// <param name="author">
        /// The author(s) of the research paper
        /// </param>
        /// <param name="publishedAt">
        /// The date and time the research paper was published
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemResearchPaperPropertiesResearchPaper(
            string? title,
            string? author,
            string? publishedAt)
        {
            this.Title = title;
            this.Author = author;
            this.PublishedAt = publishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemResearchPaperPropertiesResearchPaper" /> class.
        /// </summary>
        public WebsetItemResearchPaperPropertiesResearchPaper()
        {
        }

    }
}