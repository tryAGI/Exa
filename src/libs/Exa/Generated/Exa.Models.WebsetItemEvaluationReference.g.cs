
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemEvaluationReference
    {
        /// <summary>
        /// The title of the reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The relevant snippet of the reference content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snippet")]
        public string? Snippet { get; set; }

        /// <summary>
        /// The URL of the reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemEvaluationReference" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the reference
        /// </param>
        /// <param name="title">
        /// The title of the reference
        /// </param>
        /// <param name="snippet">
        /// The relevant snippet of the reference content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemEvaluationReference(
            string url,
            string? title,
            string? snippet)
        {
            this.Title = title;
            this.Snippet = snippet;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemEvaluationReference" /> class.
        /// </summary>
        public WebsetItemEvaluationReference()
        {
        }

    }
}