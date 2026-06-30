
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchMonitorRunOutputGroundingVariant1Item
    {
        /// <summary>
        /// The output field this citation applies to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation> Citations { get; set; }

        /// <summary>
        /// Model-reported reliability for this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.SearchMonitorRunOutputGroundingVariant1ItemConfidenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorRunOutputGroundingVariant1Item" /> class.
        /// </summary>
        /// <param name="field">
        /// The output field this citation applies to
        /// </param>
        /// <param name="citations"></param>
        /// <param name="confidence">
        /// Model-reported reliability for this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMonitorRunOutputGroundingVariant1Item(
            string field,
            global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1ItemCitation> citations,
            global::Exa.SearchMonitorRunOutputGroundingVariant1ItemConfidence confidence)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorRunOutputGroundingVariant1Item" /> class.
        /// </summary>
        public SearchMonitorRunOutputGroundingVariant1Item()
        {
        }

    }
}