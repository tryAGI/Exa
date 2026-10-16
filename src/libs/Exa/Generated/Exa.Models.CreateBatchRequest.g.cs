
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateBatchRequest
    {
        /// <summary>
        /// The requests to enqueue. Each `customId` must be unique within the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.BatchRequestItem> Requests { get; set; }

        /// <summary>
        /// Caller-provided metadata stored with the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        /// <param name="requests">
        /// The requests to enqueue. Each `customId` must be unique within the batch.
        /// </param>
        /// <param name="metadata">
        /// Caller-provided metadata stored with the batch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBatchRequest(
            global::System.Collections.Generic.IList<global::Exa.BatchRequestItem> requests,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBatchRequest" /> class.
        /// </summary>
        public CreateBatchRequest()
        {
        }

    }
}