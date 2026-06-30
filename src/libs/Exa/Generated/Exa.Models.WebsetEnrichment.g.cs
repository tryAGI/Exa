
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetEnrichment
    {
        /// <summary>
        /// The unique identifier for the enrichment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: webset_enrichment
        /// </summary>
        /// <default>"webset_enrichment"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "webset_enrichment";

        /// <summary>
        /// The status of the enrichment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetEnrichmentStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetEnrichmentStatus Status { get; set; }

        /// <summary>
        /// The unique identifier for the Webset this enrichment belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("websetId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebsetId { get; set; }

        /// <summary>
        /// The title of the enrichment.<br/>
        /// This will be automatically generated based on the description and format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The description of the enrichment task provided during the creation of the enrichment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The format of the enrichment response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetEnrichmentFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetEnrichmentFormat Format { get; set; }

        /// <summary>
        /// When the format is options, the different options for the enrichment agent to choose from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Exa.WebsetEnrichmentOption>? Options { get; set; }

        /// <summary>
        /// The instructions for the enrichment Agent.<br/>
        /// This will be automatically generated based on the description and format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The metadata of the enrichment<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The date and time the enrichment was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the enrichment was updated
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
        /// Initializes a new instance of the <see cref="WebsetEnrichment" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the enrichment
        /// </param>
        /// <param name="status">
        /// The status of the enrichment
        /// </param>
        /// <param name="websetId">
        /// The unique identifier for the Webset this enrichment belongs to.
        /// </param>
        /// <param name="description">
        /// The description of the enrichment task provided during the creation of the enrichment.
        /// </param>
        /// <param name="format">
        /// The format of the enrichment response.
        /// </param>
        /// <param name="createdAt">
        /// The date and time the enrichment was created
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the enrichment was updated
        /// </param>
        /// <param name="title">
        /// The title of the enrichment.<br/>
        /// This will be automatically generated based on the description and format.
        /// </param>
        /// <param name="options">
        /// When the format is options, the different options for the enrichment agent to choose from.
        /// </param>
        /// <param name="instructions">
        /// The instructions for the enrichment Agent.<br/>
        /// This will be automatically generated based on the description and format.
        /// </param>
        /// <param name="metadata">
        /// The metadata of the enrichment<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="object">
        /// Default Value: webset_enrichment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetEnrichment(
            string id,
            global::Exa.WebsetEnrichmentStatus status,
            string websetId,
            string description,
            global::Exa.WebsetEnrichmentFormat format,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? title,
            global::System.Collections.Generic.IList<global::Exa.WebsetEnrichmentOption>? options,
            string? instructions,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string @object = "webset_enrichment")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.WebsetId = websetId ?? throw new global::System.ArgumentNullException(nameof(websetId));
            this.Title = title;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Format = format;
            this.Options = options;
            this.Instructions = instructions;
            this.Metadata = metadata;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetEnrichment" /> class.
        /// </summary>
        public WebsetEnrichment()
        {
        }

    }
}