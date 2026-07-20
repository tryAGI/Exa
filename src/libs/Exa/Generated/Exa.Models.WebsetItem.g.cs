
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItem
    {
        /// <summary>
        /// The unique identifier for the Webset Item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: webset_item
        /// </summary>
        /// <default>"webset_item"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "webset_item";

        /// <summary>
        /// The source of the Item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetItemSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetItemSource Source { get; set; }

        /// <summary>
        /// The unique identifier for the source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// The original identifier used to resolve this item (e.g., email, name, or URL). Only relevant when the source is import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceEntityId")]
        public string? SourceEntityId { get; set; }

        /// <summary>
        /// The import that sourced this item, when the item came from a scoped search with evaluate enabled on the import.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopeId")]
        public string? ScopeId { get; set; }

        /// <summary>
        /// The unique identifier for the Webset this Item belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsetId { get; set; }

        /// <summary>
        /// The properties of the Item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties> Properties { get; set; }

        /// <summary>
        /// The criteria evaluations of the item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluation> Evaluations { get; set; }

        /// <summary>
        /// The enrichments results of the Webset item
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichments")]
        public global::System.Collections.Generic.IList<global::Exa.EnrichmentResult>? Enrichments { get; set; }

        /// <summary>
        /// The date and time the item was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the item was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the Webset Item
        /// </param>
        /// <param name="source">
        /// The source of the Item
        /// </param>
        /// <param name="sourceId">
        /// The unique identifier for the source
        /// </param>
        /// <param name="websetId">
        /// The unique identifier for the Webset this Item belongs to.
        /// </param>
        /// <param name="properties">
        /// The properties of the Item
        /// </param>
        /// <param name="evaluations">
        /// The criteria evaluations of the item
        /// </param>
        /// <param name="createdAt">
        /// The date and time the item was created
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the item was last updated
        /// </param>
        /// <param name="sourceEntityId">
        /// The original identifier used to resolve this item (e.g., email, name, or URL). Only relevant when the source is import.
        /// </param>
        /// <param name="scopeId">
        /// The import that sourced this item, when the item came from a scoped search with evaluate enabled on the import.
        /// </param>
        /// <param name="enrichments">
        /// The enrichments results of the Webset item
        /// </param>
        /// <param name="object">
        /// Default Value: webset_item
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItem(
            string id,
            global::Exa.WebsetItemSource source,
            string sourceId,
            string websetId,
            global::Exa.OneOf<global::Exa.WebsetItemPersonProperties, global::Exa.WebsetItemCompanyProperties, global::Exa.WebsetItemArticleProperties, global::Exa.WebsetItemResearchPaperProperties, global::Exa.WebsetItemCustomProperties> properties,
            global::System.Collections.Generic.IList<global::Exa.WebsetItemEvaluation> evaluations,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? sourceEntityId,
            string? scopeId,
            global::System.Collections.Generic.IList<global::Exa.EnrichmentResult>? enrichments,
            string @object = "webset_item")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Source = source;
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.SourceEntityId = sourceEntityId;
            this.ScopeId = scopeId;
            this.WebsetId = websetId ?? throw new global::System.ArgumentNullException(nameof(websetId));
            this.Properties = properties;
            this.Evaluations = evaluations ?? throw new global::System.ArgumentNullException(nameof(evaluations));
            this.Enrichments = enrichments;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItem" /> class.
        /// </summary>
        public WebsetItem()
        {
        }

    }
}