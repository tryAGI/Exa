
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentGrounding
    {
        /// <summary>
        /// Output field the citations support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Field { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.AgentCitation> Citations { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public global::Exa.AgentGroundingConfidence? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGrounding" /> class.
        /// </summary>
        /// <param name="field">
        /// Output field the citations support.
        /// </param>
        /// <param name="citations"></param>
        /// <param name="confidence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentGrounding(
            string field,
            global::System.Collections.Generic.IList<global::Exa.AgentCitation> citations,
            global::Exa.AgentGroundingConfidence? confidence)
        {
            this.Field = field ?? throw new global::System.ArgumentNullException(nameof(field));
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGrounding" /> class.
        /// </summary>
        public AgentGrounding()
        {
        }

    }
}