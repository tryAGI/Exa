
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemArticleProperties
    {
        /// <summary>
        /// Default Value: article
        /// </summary>
        /// <default>"article"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "article";

        /// <summary>
        /// The URL of the article
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Short description of the relevance of the article
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The text content for the article
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("article")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetItemArticlePropertiesArticle Article { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemArticleProperties" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the article
        /// </param>
        /// <param name="description">
        /// Short description of the relevance of the article
        /// </param>
        /// <param name="article"></param>
        /// <param name="content">
        /// The text content for the article
        /// </param>
        /// <param name="type">
        /// Default Value: article
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemArticleProperties(
            string url,
            string description,
            global::Exa.WebsetItemArticlePropertiesArticle article,
            string? content,
            string type = "article")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Content = content;
            this.Article = article ?? throw new global::System.ArgumentNullException(nameof(article));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemArticleProperties" /> class.
        /// </summary>
        public WebsetItemArticleProperties()
        {
        }

    }
}