
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContentsResponseStatuse
    {
        /// <summary>
        /// The URL or document ID that was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Status of the content fetch operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ContentsResponseStatuseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ContentsResponseStatuseStatus Status { get; set; }

        /// <summary>
        /// Where the returned content was sourced from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ContentsResponseStatuseSourceJsonConverter))]
        public global::Exa.ContentsResponseStatuseSource? Source { get; set; }

        /// <summary>
        /// Error details, only present when status is "error".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::Exa.ContentsResponseStatuseError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsResponseStatuse" /> class.
        /// </summary>
        /// <param name="id">
        /// The URL or document ID that was requested.
        /// </param>
        /// <param name="status">
        /// Status of the content fetch operation.
        /// </param>
        /// <param name="source">
        /// Where the returned content was sourced from.
        /// </param>
        /// <param name="error">
        /// Error details, only present when status is "error".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsResponseStatuse(
            string id,
            global::Exa.ContentsResponseStatuseStatus status,
            global::Exa.ContentsResponseStatuseSource? source,
            global::Exa.ContentsResponseStatuseError? error)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Source = source;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsResponseStatuse" /> class.
        /// </summary>
        public ContentsResponseStatuse()
        {
        }

    }
}