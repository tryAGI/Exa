
#nullable enable

namespace Exa
{
    /// <summary>
    /// Citation from research sources
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitation
    {
        /// <summary>
        /// Unique identifier for the cited document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// URL of the cited source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Title of the cited source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// URL of the favicon associated with the result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// URL of the image associated with the result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitation" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the cited document
        /// </param>
        /// <param name="url">
        /// URL of the cited source
        /// </param>
        /// <param name="title">
        /// Title of the cited source
        /// </param>
        /// <param name="favicon">
        /// URL of the favicon associated with the result
        /// </param>
        /// <param name="image">
        /// URL of the image associated with the result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitation(
            string id,
            string url,
            string title,
            string? favicon,
            string? image)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Favicon = favicon;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitation" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitation()
        {
        }

    }
}