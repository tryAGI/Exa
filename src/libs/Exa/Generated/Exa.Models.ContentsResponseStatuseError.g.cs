
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ContentsResponseStatuseError
    {
        /// <summary>
        /// Specific error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// The corresponding HTTP status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpStatusCode")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsResponseStatuseError" /> class.
        /// </summary>
        /// <param name="tag">
        /// Specific error type.
        /// </param>
        /// <param name="httpStatusCode">
        /// The corresponding HTTP status code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsResponseStatuseError(
            string? tag,
            int? httpStatusCode)
        {
            this.Tag = tag;
            this.HttpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsResponseStatuseError" /> class.
        /// </summary>
        public ContentsResponseStatuseError()
        {
        }

    }
}