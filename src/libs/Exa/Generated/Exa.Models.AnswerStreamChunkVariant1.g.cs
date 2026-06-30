
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerStreamChunkVariant1
    {
        /// <summary>
        /// OpenAI-compatible streamed completion choices with internal provider fields removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.AnswerStreamChunkVariant1Choice> Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamChunkVariant1" /> class.
        /// </summary>
        /// <param name="choices">
        /// OpenAI-compatible streamed completion choices with internal provider fields removed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerStreamChunkVariant1(
            global::System.Collections.Generic.IList<global::Exa.AnswerStreamChunkVariant1Choice> choices)
        {
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamChunkVariant1" /> class.
        /// </summary>
        public AnswerStreamChunkVariant1()
        {
        }

    }
}