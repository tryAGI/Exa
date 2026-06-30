
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnrichmentResult
    {
        /// <summary>
        /// Default Value: enrichment_result
        /// </summary>
        /// <default>"enrichment_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "enrichment_result";

        /// <summary>
        /// The status of the enrichment result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.EnrichmentResultStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.EnrichmentResultStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.WebsetEnrichmentFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetEnrichmentFormat Format { get; set; }

        /// <summary>
        /// The result of the enrichment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public global::System.Collections.Generic.IList<string>? Result { get; set; }

        /// <summary>
        /// The reasoning for the result when an Agent is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        public string? Reasoning { get; set; }

        /// <summary>
        /// The references used to generate the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.EnrichmentResultReference> References { get; set; }

        /// <summary>
        /// The id of the Enrichment that generated the result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnrichmentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentResult" /> class.
        /// </summary>
        /// <param name="status">
        /// The status of the enrichment result.
        /// </param>
        /// <param name="format"></param>
        /// <param name="references">
        /// The references used to generate the result.
        /// </param>
        /// <param name="enrichmentId">
        /// The id of the Enrichment that generated the result
        /// </param>
        /// <param name="result">
        /// The result of the enrichment.
        /// </param>
        /// <param name="reasoning">
        /// The reasoning for the result when an Agent is used.
        /// </param>
        /// <param name="object">
        /// Default Value: enrichment_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnrichmentResult(
            global::Exa.EnrichmentResultStatus status,
            global::Exa.WebsetEnrichmentFormat format,
            global::System.Collections.Generic.IList<global::Exa.EnrichmentResultReference> references,
            string enrichmentId,
            global::System.Collections.Generic.IList<string>? result,
            string? reasoning,
            string @object = "enrichment_result")
        {
            this.Object = @object;
            this.Status = status;
            this.Format = format;
            this.Result = result;
            this.Reasoning = reasoning;
            this.References = references ?? throw new global::System.ArgumentNullException(nameof(references));
            this.EnrichmentId = enrichmentId ?? throw new global::System.ArgumentNullException(nameof(enrichmentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnrichmentResult" /> class.
        /// </summary>
        public EnrichmentResult()
        {
        }

    }
}