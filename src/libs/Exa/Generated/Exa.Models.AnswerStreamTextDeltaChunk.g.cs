
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerStreamTextDeltaChunk
    {
        /// <summary>
        /// Streamed completion choices in the OpenAI chat completions format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.AnswerStreamTextDeltaChunkChoice> Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamTextDeltaChunk" /> class.
        /// </summary>
        /// <param name="choices">
        /// Streamed completion choices in the OpenAI chat completions format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerStreamTextDeltaChunk(
            global::System.Collections.Generic.IList<global::Exa.AnswerStreamTextDeltaChunkChoice> choices)
        {
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamTextDeltaChunk" /> class.
        /// </summary>
        public AnswerStreamTextDeltaChunk()
        {
        }

    }
}