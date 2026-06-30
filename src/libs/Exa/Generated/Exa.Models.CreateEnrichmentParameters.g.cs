
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEnrichmentParameters
    {
        /// <summary>
        /// Provide a description of the enrichment task you want to perform to each Webset Item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Format of the enrichment response.<br/>
        /// We automatically select the best format based on the description. If you want to explicitly specify the format, you can do so here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.CreateEnrichmentParametersFormatJsonConverter))]
        public global::Exa.CreateEnrichmentParametersFormat? Format { get; set; }

        /// <summary>
        /// When the format is options, the different options for the enrichment agent to choose from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParametersOption>? Options { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateEnrichmentParameters" /> class.
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
        public CreateEnrichmentParameters(
            string description,
            global::Exa.CreateEnrichmentParametersFormat? format,
            global::System.Collections.Generic.IList<global::Exa.CreateEnrichmentParametersOption>? options,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Format = format;
            this.Options = options;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnrichmentParameters" /> class.
        /// </summary>
        public CreateEnrichmentParameters()
        {
        }

    }
}