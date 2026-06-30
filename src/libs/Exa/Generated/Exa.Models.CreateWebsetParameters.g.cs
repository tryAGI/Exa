
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebsetParameters
    {
        /// <summary>
        /// Optional name that appears anywhere the Webset is displayed. Leave empty to have Exa generate one automatically.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Create initial search for the Webset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public global::Exa.CreateWebsetParametersSearch? Search { get; set; }

        /// <summary>
        /// Import data from existing Websets and Imports into this Webset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("import")]
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersImportItem>? Import { get; set; }

        /// <summary>
        /// Add enrichments to extract additional data from found items.<br/>
        /// Enrichments automatically search for and extract specific information (like contact details, funding data, employee counts, etc.) from each item added to your Webset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichments")]
        public global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParameters>? Enrichments { get; set; }

        /// <summary>
        /// Global exclusion sources (existing imports or websets) that apply to all operations within this Webset. Any results found within these sources will be omitted across all search and import operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>? Exclude { get; set; }

        /// <summary>
        /// The external identifier for the webset.<br/>
        /// You can use this to reference the Webset by your own internal identifiers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Set of key-value pairs you want to associate with this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetParameters" /> class.
        /// </summary>
        /// <param name="title">
        /// Optional name that appears anywhere the Webset is displayed. Leave empty to have Exa generate one automatically.
        /// </param>
        /// <param name="search">
        /// Create initial search for the Webset.
        /// </param>
        /// <param name="import">
        /// Import data from existing Websets and Imports into this Webset.
        /// </param>
        /// <param name="enrichments">
        /// Add enrichments to extract additional data from found items.<br/>
        /// Enrichments automatically search for and extract specific information (like contact details, funding data, employee counts, etc.) from each item added to your Webset.
        /// </param>
        /// <param name="exclude">
        /// Global exclusion sources (existing imports or websets) that apply to all operations within this Webset. Any results found within these sources will be omitted across all search and import operations.
        /// </param>
        /// <param name="externalId">
        /// The external identifier for the webset.<br/>
        /// You can use this to reference the Webset by your own internal identifiers.
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebsetParameters(
            string? title,
            global::Exa.CreateWebsetParametersSearch? search,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersImportItem>? import,
            global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParameters>? enrichments,
            global::System.Collections.Generic.IList<global::Exa.CreateWebsetParametersExcludeItem>? exclude,
            string? externalId,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Title = title;
            this.Search = search;
            this.Import = import;
            this.Enrichments = enrichments;
            this.Exclude = exclude;
            this.ExternalId = externalId;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetParameters" /> class.
        /// </summary>
        public CreateWebsetParameters()
        {
        }

    }
}