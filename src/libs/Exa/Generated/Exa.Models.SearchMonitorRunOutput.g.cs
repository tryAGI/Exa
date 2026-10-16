
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchMonitorRunOutput
    {
        /// <summary>
        /// The search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? Results { get; set; }

        /// <summary>
        /// Synthesized content from the search results. Shape depends on `outputSchema.type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Exa.JsonValue? Content { get; set; }

        /// <summary>
        /// Field-level citations with confidence levels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding")]
        public global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>? Grounding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorRunOutput" /> class.
        /// </summary>
        /// <param name="results">
        /// The search results
        /// </param>
        /// <param name="content">
        /// Synthesized content from the search results. Shape depends on `outputSchema.type`.
        /// </param>
        /// <param name="grounding">
        /// Field-level citations with confidence levels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchMonitorRunOutput(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>? results,
            global::Exa.JsonValue? content,
            global::System.Collections.Generic.IList<global::Exa.SearchMonitorRunOutputGroundingVariant1Item>? grounding)
        {
            this.Results = results;
            this.Content = content;
            this.Grounding = grounding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchMonitorRunOutput" /> class.
        /// </summary>
        public SearchMonitorRunOutput()
        {
        }

    }
}