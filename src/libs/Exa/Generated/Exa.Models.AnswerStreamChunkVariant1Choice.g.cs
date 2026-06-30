
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerStreamChunkVariant1Choice
    {
        /// <summary>
        /// Index of this streamed choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Incremental answer content emitted by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AnswerStreamChunkVariant1ChoiceDelta Delta { get; set; }

        /// <summary>
        /// Reason this streamed choice finished, when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::Exa.OneOf<string, object>? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamChunkVariant1Choice" /> class.
        /// </summary>
        /// <param name="index">
        /// Index of this streamed choice.
        /// </param>
        /// <param name="delta">
        /// Incremental answer content emitted by the model.
        /// </param>
        /// <param name="finishReason">
        /// Reason this streamed choice finished, when present.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerStreamChunkVariant1Choice(
            int index,
            global::Exa.AnswerStreamChunkVariant1ChoiceDelta delta,
            global::Exa.OneOf<string, object>? finishReason)
        {
            this.Index = index;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamChunkVariant1Choice" /> class.
        /// </summary>
        public AnswerStreamChunkVariant1Choice()
        {
        }

    }
}