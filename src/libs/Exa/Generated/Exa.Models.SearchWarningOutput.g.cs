
#nullable enable

namespace Exa
{
    /// <summary>
    /// A note about the request itself, for whoever maintains the code that builds it. Log it; do not pass it to a model. A warning never changes the status code or the results.
    /// </summary>
    public sealed partial class SearchWarningOutput
    {
        /// <summary>
        /// Machine-readable warning code, UPPER_SNAKE. `IGNORED_FIELD`: the field at `path` is accepted and has no effect. Codes are an open set: tolerate codes you do not recognize.<br/>
        /// Example: IGNORED_FIELD
        /// </summary>
        /// <example>IGNORED_FIELD</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// JSON Pointer to the request field the warning is about.<br/>
        /// Example: /startCrawlDate
        /// </summary>
        /// <example>/startCrawlDate</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Human-readable and complete on its own: what to change in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWarningOutput" /> class.
        /// </summary>
        /// <param name="code">
        /// Machine-readable warning code, UPPER_SNAKE. `IGNORED_FIELD`: the field at `path` is accepted and has no effect. Codes are an open set: tolerate codes you do not recognize.<br/>
        /// Example: IGNORED_FIELD
        /// </param>
        /// <param name="path">
        /// JSON Pointer to the request field the warning is about.<br/>
        /// Example: /startCrawlDate
        /// </param>
        /// <param name="message">
        /// Human-readable and complete on its own: what to change in the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchWarningOutput(
            string code,
            string path,
            string message)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchWarningOutput" /> class.
        /// </summary>
        public SearchWarningOutput()
        {
        }

    }
}