
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Batch
    {
        /// <summary>
        /// Batch ID. New batch IDs are returned with the `batch_` prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, always `batch`.
        /// </summary>
        /// <default>"batch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "batch";

        /// <summary>
        /// Lifecycle status of the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.BatchStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.BatchStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestCounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.BatchRequestCounts RequestCounts { get; set; }

        /// <summary>
        /// When the batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the batch expires, or `null` if it does not expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// When the batch reached a terminal status, or `null` while it is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endedAt")]
        public global::System.DateTime? EndedAt { get; set; }

        /// <summary>
        /// Short-lived download URL for the batch results file (JSONL), or `null` until the batch completes. Fetch it directly, without an API key. Retrieve the batch again for a fresh URL after it expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resultsUrl")]
        public string? ResultsUrl { get; set; }

        /// <summary>
        /// Caller-provided key-value metadata for your own tracking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        /// <param name="id">
        /// Batch ID. New batch IDs are returned with the `batch_` prefix.
        /// </param>
        /// <param name="status">
        /// Lifecycle status of the batch.
        /// </param>
        /// <param name="requestCounts"></param>
        /// <param name="createdAt">
        /// When the batch was created.
        /// </param>
        /// <param name="metadata">
        /// Caller-provided key-value metadata for your own tracking.
        /// </param>
        /// <param name="expiresAt">
        /// When the batch expires, or `null` if it does not expire.
        /// </param>
        /// <param name="endedAt">
        /// When the batch reached a terminal status, or `null` while it is still running.
        /// </param>
        /// <param name="resultsUrl">
        /// Short-lived download URL for the batch results file (JSONL), or `null` until the batch completes. Fetch it directly, without an API key. Retrieve the batch again for a fresh URL after it expires.
        /// </param>
        /// <param name="object">
        /// The object type, always `batch`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Batch(
            string id,
            global::Exa.BatchStatus status,
            global::Exa.BatchRequestCounts requestCounts,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime? expiresAt,
            global::System.DateTime? endedAt,
            string? resultsUrl,
            string @object = "batch")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Status = status;
            this.RequestCounts = requestCounts ?? throw new global::System.ArgumentNullException(nameof(requestCounts));
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.EndedAt = endedAt;
            this.ResultsUrl = resultsUrl;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Batch" /> class.
        /// </summary>
        public Batch()
        {
        }

    }
}