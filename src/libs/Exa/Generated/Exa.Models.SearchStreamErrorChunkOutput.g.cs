
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchStreamErrorChunkOutput
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.SearchStreamErrorChunkOutputError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamErrorChunkOutput" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamErrorChunkOutput(
            global::Exa.SearchStreamErrorChunkOutputError error,
            string? requestId,
            string type = "error")
        {
            this.RequestId = requestId;
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamErrorChunkOutput" /> class.
        /// </summary>
        public SearchStreamErrorChunkOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SearchStreamErrorChunkOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SearchStreamErrorChunkOutput FromError(global::Exa.SearchStreamErrorChunkOutputError error)
        {
            return new SearchStreamErrorChunkOutput
            {
                Error = error,
            };
        }

    }
}