
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchStreamTextDeltaChunkOutputChoice
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchStreamTextDeltaChunkOutputChoiceDelta Delta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        public string? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamTextDeltaChunkOutputChoice" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamTextDeltaChunkOutputChoice(
            int index,
            global::Exa.SearchStreamTextDeltaChunkOutputChoiceDelta delta,
            string? finishReason)
        {
            this.Index = index;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamTextDeltaChunkOutputChoice" /> class.
        /// </summary>
        public SearchStreamTextDeltaChunkOutputChoice()
        {
        }

    }
}