
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentApiKeyBudgetExceededResponse
    {
        /// <summary>
        /// HTTP status code of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// When the error occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// What went wrong and how to resolve it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Machine-readable error tag.
        /// </summary>
        /// <default>"API_KEY_BUDGET_EXCEEDED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; set; } = "API_KEY_BUDGET_EXCEEDED";

        /// <summary>
        /// Request path that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// ID of the failed request, for support.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentApiKeyBudgetExceededResponse" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP status code of the response.
        /// </param>
        /// <param name="timestamp">
        /// When the error occurred.
        /// </param>
        /// <param name="message">
        /// What went wrong and how to resolve it.
        /// </param>
        /// <param name="path">
        /// Request path that failed.
        /// </param>
        /// <param name="requestId">
        /// ID of the failed request, for support.
        /// </param>
        /// <param name="error">
        /// Machine-readable error tag.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentApiKeyBudgetExceededResponse(
            int statusCode,
            global::System.DateTime timestamp,
            string message,
            string path,
            string requestId,
            string error = "API_KEY_BUDGET_EXCEEDED")
        {
            this.StatusCode = statusCode;
            this.Timestamp = timestamp;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Error = error;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentApiKeyBudgetExceededResponse" /> class.
        /// </summary>
        public AgentApiKeyBudgetExceededResponse()
        {
        }

    }
}