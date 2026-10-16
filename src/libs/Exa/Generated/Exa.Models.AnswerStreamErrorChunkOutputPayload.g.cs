
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerStreamErrorChunkOutputPayload
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.AnswerStreamErrorChunkOutputPayloadError Error { get; set; }

        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamErrorChunkOutputPayload" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerStreamErrorChunkOutputPayload(
            global::Exa.AnswerStreamErrorChunkOutputPayloadError error,
            string? requestId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerStreamErrorChunkOutputPayload" /> class.
        /// </summary>
        public AnswerStreamErrorChunkOutputPayload()
        {
        }

    }
}