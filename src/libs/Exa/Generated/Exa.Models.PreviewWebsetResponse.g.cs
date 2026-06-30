
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewWebsetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.PreviewWebsetResponseSearch Search { get; set; }

        /// <summary>
        /// Detected enrichments from the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enrichments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichment> Enrichments { get; set; }

        /// <summary>
        /// Preview items matching the search criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.WebsetItemPreview> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebsetResponse" /> class.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="enrichments">
        /// Detected enrichments from the query.
        /// </param>
        /// <param name="items">
        /// Preview items matching the search criteria.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewWebsetResponse(
            global::Exa.PreviewWebsetResponseSearch search,
            global::System.Collections.Generic.IList<global::Exa.PreviewWebsetResponseEnrichment> enrichments,
            global::System.Collections.Generic.IList<global::Exa.WebsetItemPreview> items)
        {
            this.Search = search ?? throw new global::System.ArgumentNullException(nameof(search));
            this.Enrichments = enrichments ?? throw new global::System.ArgumentNullException(nameof(enrichments));
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreviewWebsetResponse" /> class.
        /// </summary>
        public PreviewWebsetResponse()
        {
        }

    }
}