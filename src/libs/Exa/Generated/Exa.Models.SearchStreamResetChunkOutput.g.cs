
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchStreamResetChunkOutput
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"stream-reset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "stream-reset";

        /// <summary>
        ///
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("streamReset")]
        public bool StreamReset { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamResetChunkOutput" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="type"></param>
        /// <param name="streamReset"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamResetChunkOutput(
            string? requestId,
            string type = "stream-reset",
            bool streamReset = true)
        {
            this.RequestId = requestId;
            this.Type = type;
            this.StreamReset = streamReset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamResetChunkOutput" /> class.
        /// </summary>
        public SearchStreamResetChunkOutput()
        {
        }

    }
}