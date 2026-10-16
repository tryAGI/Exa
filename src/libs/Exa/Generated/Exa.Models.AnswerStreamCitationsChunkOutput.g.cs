
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerStreamCitationsChunkOutput
    {
        /// <summary>
        /// Search results cited by the final streamed answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.AnswerStreamCitationsChunkOutputCitation> Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamCitationsChunkOutput" /> class.
        /// </summary>
        /// <param name="citations">
        /// Search results cited by the final streamed answer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerStreamCitationsChunkOutput(
            global::System.Collections.Generic.IList<global::Exa.AnswerStreamCitationsChunkOutputCitation> citations)
        {
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamCitationsChunkOutput" /> class.
        /// </summary>
        public AnswerStreamCitationsChunkOutput()
        {
        }

    }
}