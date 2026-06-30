
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Webset
    {
        /// <summary>
        /// The unique identifier for the webset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: webset
        /// </summary>
        /// <default>"webset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "webset";

        /// <summary>
        /// The status of the webset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetStatus Status { get; set; }

        /// <summary>
        /// The external identifier for the webset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// The title of the webset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The searches that have been performed on the webset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searches")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.WebsetSearch> Searches { get; set; }

        /// <summary>
        /// Imports that have been performed on the webset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imports")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.Import> Imports { get; set; }

        /// <summary>
        /// The Enrichments to apply to the Webset Items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.WebsetEnrichment> Enrichments { get; set; }

        /// <summary>
        /// The Monitors for the Webset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monitors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.Monitor> Monitors { get; set; }

        /// <summary>
        /// The Excludes sources (existing imports or websets) that apply to all operations within this Webset. Any results found within these sources will be omitted across all search and import operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludes")]
        public global::System.Collections.Generic.IList<global::Exa.WebsetExclude>? Excludes { get; set; }

        /// <summary>
        /// Set of key-value pairs you want to associate with this object.<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The URL to view the webset in the Exa dashboard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dashboardUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DashboardUrl { get; set; }

        /// <summary>
        /// The date and time the webset was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time the webset was updated
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
        /// Initializes a new instance of the <see cref="Webset" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the webset
        /// </param>
        /// <param name="status">
        /// The status of the webset
        /// </param>
        /// <param name="searches">
        /// The searches that have been performed on the webset.
        /// </param>
        /// <param name="imports">
        /// Imports that have been performed on the webset.
        /// </param>
        /// <param name="enrichments">
        /// The Enrichments to apply to the Webset Items.
        /// </param>
        /// <param name="monitors">
        /// The Monitors for the Webset.
        /// </param>
        /// <param name="dashboardUrl">
        /// The URL to view the webset in the Exa dashboard
        /// </param>
        /// <param name="createdAt">
        /// The date and time the webset was created
        /// </param>
        /// <param name="updatedAt">
        /// The date and time the webset was updated
        /// </param>
        /// <param name="externalId">
        /// The external identifier for the webset
        /// </param>
        /// <param name="title">
        /// The title of the webset
        /// </param>
        /// <param name="excludes">
        /// The Excludes sources (existing imports or websets) that apply to all operations within this Webset. Any results found within these sources will be omitted across all search and import operations.
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="object">
        /// Default Value: webset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Webset(
            string id,
            global::Exa.WebsetStatus status,
            global::System.Collections.Generic.IList<global::Exa.WebsetSearch> searches,
            global::System.Collections.Generic.IList<global::Exa.Import> imports,
            global::System.Collections.Generic.IList<global::Exa.WebsetEnrichment> enrichments,
            global::System.Collections.Generic.IList<global::Exa.Monitor> monitors,
            string dashboardUrl,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? externalId,
            string? title,
            global::System.Collections.Generic.IList<global::Exa.WebsetExclude>? excludes,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string @object = "webset")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.ExternalId = externalId;
            this.Title = title;
            this.Searches = searches ?? throw new global::System.ArgumentNullException(nameof(searches));
            this.Imports = imports ?? throw new global::System.ArgumentNullException(nameof(imports));
            this.Enrichments = enrichments ?? throw new global::System.ArgumentNullException(nameof(enrichments));
            this.Monitors = monitors ?? throw new global::System.ArgumentNullException(nameof(monitors));
            this.Excludes = excludes;
            this.Metadata = metadata;
            this.DashboardUrl = dashboardUrl ?? throw new global::System.ArgumentNullException(nameof(dashboardUrl));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Webset" /> class.
        /// </summary>
        public Webset()
        {
        }

    }
}