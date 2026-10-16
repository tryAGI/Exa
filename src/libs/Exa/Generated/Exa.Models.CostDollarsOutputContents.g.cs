
#nullable enable

namespace Exa
{
    /// <summary>
    /// Estimated cost breakdown for standalone content retrieval (text, highlights, and summaries billed outside the bundled search price).
    /// </summary>
    public sealed partial class CostDollarsOutputContents
    {
        /// <summary>
        /// Cost of text extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public float? Text { get; set; }

        /// <summary>
        /// Cost of highlight extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlights")]
        public float? Highlights { get; set; }

        /// <summary>
        /// Cost of per-result summary generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public float? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutputContents" /> class.
        /// </summary>
        /// <param name="text">
        /// Cost of text extraction.
        /// </param>
        /// <param name="highlights">
        /// Cost of highlight extraction.
        /// </param>
        /// <param name="summary">
        /// Cost of per-result summary generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostDollarsOutputContents(
            float? text,
            float? highlights,
            float? summary)
        {
            this.Text = text;
            this.Highlights = highlights;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostDollarsOutputContents" /> class.
        /// </summary>
        public CostDollarsOutputContents()
        {
        }

    }
}