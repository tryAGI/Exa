
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemPreview
    {
        /// <summary>
        /// The unique identifier for the preview item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The properties of the preview item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties> Properties { get; set; }

        /// <summary>
        /// The date and time the preview was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPreview" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the preview item
        /// </param>
        /// <param name="properties">
        /// The properties of the preview item
        /// </param>
        /// <param name="createdAt">
        /// The date and time the preview was created
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemPreview(
            string id,
            global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties> properties,
            global::System.DateTime createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Properties = properties;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPreview" /> class.
        /// </summary>
        public WebsetItemPreview()
        {
        }

    }
}