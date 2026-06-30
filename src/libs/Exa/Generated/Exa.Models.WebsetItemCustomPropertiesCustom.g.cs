
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemCustomPropertiesCustom
    {
        /// <summary>
        /// The title of the website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The author(s) of the website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("author")]
        public string? Author { get; set; }

        /// <summary>
        /// The date and time the website was published
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publishedAt")]
        public string? PublishedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCustomPropertiesCustom" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the website
        /// </param>
        /// <param name="author">
        /// The author(s) of the website
        /// </param>
        /// <param name="publishedAt">
        /// The date and time the website was published
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemCustomPropertiesCustom(
            string? title,
            string? author,
            string? publishedAt)
        {
            this.Title = title;
            this.Author = author;
            this.PublishedAt = publishedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCustomPropertiesCustom" /> class.
        /// </summary>
        public WebsetItemCustomPropertiesCustom()
        {
        }

    }
}