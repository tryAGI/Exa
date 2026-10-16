
#nullable enable

namespace Exa
{
    /// <summary>
    /// A note about how the results were produced, written to be passed to a model with the results.
    /// </summary>
    public sealed partial class SearchNoticeOutput
    {
        /// <summary>
        /// Machine-readable notice code, UPPER_SNAKE. `RESTRICTIONS_RELAXED`: the `site:` or exact-phrase restrictions written in the query matched nothing, so the results come from a search with them removed; filters set in the request body were kept. Codes are an open set: tolerate codes you do not recognize.<br/>
        /// Example: RESTRICTIONS_RELAXED
        /// </summary>
        /// <example>RESTRICTIONS_RELAXED</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// JSON Pointer to the request field the notice is about.<br/>
        /// Example: /query
        /// </summary>
        /// <example>/query</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Human-readable and complete on its own; written to be shown to a model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Optional extra context for a harness or model. An open object: no schema is promised for its keys, and it never carries information that `message` lacks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public object? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNoticeOutput" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable notice code, UPPER_SNAKE. `RESTRICTIONS_RELAXED`: the `site:` or exact-phrase restrictions written in the query matched nothing, so the results come from a search with them removed; filters set in the request body were kept. Codes are an open set: tolerate codes you do not recognize.<br/>
        /// Example: RESTRICTIONS_RELAXED
        /// </param>
        /// <param name="path">
        /// JSON Pointer to the request field the notice is about.<br/>
        /// Example: /query
        /// </param>
        /// <param name="message">
        /// Human-readable and complete on its own; written to be shown to a model.
        /// </param>
        /// <param name="details">
        /// Optional extra context for a harness or model. An open object: no schema is promised for its keys, and it never carries information that `message` lacks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchNoticeOutput(
            string code,
            string path,
            string message,
            object? details)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchNoticeOutput" /> class.
        /// </summary>
        public SearchNoticeOutput()
        {
        }

    }
}