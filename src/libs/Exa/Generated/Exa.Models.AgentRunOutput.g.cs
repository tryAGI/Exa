
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentRunOutput
    {
        /// <summary>
        /// Natural-language answer or summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Validated JSON matching `outputSchema`, or `null` when no schema was provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured")]
        public global::Exa.JsonValue? Structured { get; set; }

        /// <summary>
        /// Field-level citations emitted by the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grounding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.AgentGrounding> Grounding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunOutput" /> class.
        /// </summary>
        /// <param name="text">
        /// Natural-language answer or summary.
        /// </param>
        /// <param name="grounding">
        /// Field-level citations emitted by the run.
        /// </param>
        /// <param name="structured">
        /// Validated JSON matching `outputSchema`, or `null` when no schema was provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentRunOutput(
            string text,
            global::System.Collections.Generic.IList<global::Exa.AgentGrounding> grounding,
            global::Exa.JsonValue? structured)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Structured = structured;
            this.Grounding = grounding ?? throw new global::System.ArgumentNullException(nameof(grounding));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentRunOutput" /> class.
        /// </summary>
        public AgentRunOutput()
        {
        }

    }
}