
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchRequestItem
    {
        /// <summary>
        /// Your unique handle for this request; keys the result and must be unique in the batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomId { get; set; }

        /// <summary>
        /// HTTP method of the batched request. POST-only in v1.
        /// </summary>
        /// <default>"POST"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string Method { get; set; } = "POST";

        /// <summary>
        /// Target API route for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.BatchRequestItemUrlJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.BatchRequestItemUrl Url { get; set; }

        /// <summary>
        /// Request body for the target route. Must be a JSON object; `stream: true` is not allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?> Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestItem" /> class.
        /// </summary>
        /// <param name="customId">
        /// Your unique handle for this request; keys the result and must be unique in the batch.
        /// </param>
        /// <param name="url">
        /// Target API route for the request.
        /// </param>
        /// <param name="body">
        /// Request body for the target route. Must be a JSON object; `stream: true` is not allowed.
        /// </param>
        /// <param name="method">
        /// HTTP method of the batched request. POST-only in v1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchRequestItem(
            string customId,
            global::Exa.BatchRequestItemUrl url,
            global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?> body,
            string method = "POST")
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
            this.Method = method;
            this.Url = url;
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestItem" /> class.
        /// </summary>
        public BatchRequestItem()
        {
        }

    }
}