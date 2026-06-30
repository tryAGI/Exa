
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewWebsetResponseEnrichment
    {
        /// <summary>
        /// Description of the enrichment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Format of the enrichment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.PreviewWebsetResponseEnrichmentFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.PreviewWebsetResponseEnrichmentFormat Format { get; set; }

        /// <summary>
        /// When format is options, the options detected from the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichmentOption>? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebsetResponseEnrichment" /> class.
        /// </summary>
        /// <param name="description">
        /// Description of the enrichment.
        /// </param>
        /// <param name="format">
        /// Format of the enrichment.
        /// </param>
        /// <param name="options">
        /// When format is options, the options detected from the query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewWebsetResponseEnrichment(
            string description,
            global::Exa.PreviewWebsetResponseEnrichmentFormat format,
            global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichmentOption>? options)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Format = format;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebsetResponseEnrichment" /> class.
        /// </summary>
        public PreviewWebsetResponseEnrichment()
        {
        }

    }
}