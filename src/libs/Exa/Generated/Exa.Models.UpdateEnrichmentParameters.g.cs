
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEnrichmentParameters
    {
        /// <summary>
        /// Provide a description of the enrichment task you want to perform to each Webset Item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Format of the enrichment response.<br/>
        /// We automatically select the best format based on the description. If you want to explicitly specify the format, you can do so here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.UpdateEnrichmentParametersFormatJsonConverter))]
        public global::Exa.UpdateEnrichmentParametersFormat? Format { get; set; }

        /// <summary>
        /// When the format is options, the different options for the enrichment agent to choose from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>? Options { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateEnrichmentParameters" /> class.
        /// </summary>
        /// <param name="description">
        /// Provide a description of the enrichment task you want to perform to each Webset Item.
        /// </param>
        /// <param name="format">
        /// Format of the enrichment response.<br/>
        /// We automatically select the best format based on the description. If you want to explicitly specify the format, you can do so here.
        /// </param>
        /// <param name="options">
        /// When the format is options, the different options for the enrichment agent to choose from.
        /// </param>
        /// <param name="metadata">
        /// Set of key-value pairs you want to associate with this object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnrichmentParameters(
            string? description,
            global::Exa.UpdateEnrichmentParametersFormat? format,
            global::System.Collections.Generic.IList<global::Exa.UpdateEnrichmentParametersOption>? options,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Description = description;
            this.Format = format;
            this.Options = options;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnrichmentParameters" /> class.
        /// </summary>
        public UpdateEnrichmentParameters()
        {
        }

    }
}