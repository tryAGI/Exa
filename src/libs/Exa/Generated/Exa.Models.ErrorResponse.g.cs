
#nullable enable

namespace Exa
{
    /// <summary>
    /// Standard error envelope returned by the Exa API for failed requests.
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Human-readable message describing the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Machine-readable error tag identifying the failure. The set of tags is open-ended: new tags may be added at any time, so treat unrecognized tags as a generic error of the response's HTTP status. Known tags are listed as examples.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="error">
        /// Human-readable message describing the error.
        /// </param>
        /// <param name="tag">
        /// Machine-readable error tag identifying the failure. The set of tags is open-ended: new tags may be added at any time, so treat unrecognized tags as a generic error of the response's HTTP status. Known tags are listed as examples.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            string requestId,
            string error,
            string tag)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }

    }
}