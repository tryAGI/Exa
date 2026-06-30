
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentsResponseStatuseError2
    {
        /// <summary>
        /// Specific error type.<br/>
        /// Example: CRAWL_NOT_FOUND
        /// </summary>
        /// <example>CRAWL_NOT_FOUND</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// The corresponding HTTP status code.<br/>
        /// Example: 404
        /// </summary>
        /// <example>404</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpStatusCode")]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsResponseStatuseError2" /> class.
        /// </summary>
        /// <param name="tag">
        /// Specific error type.<br/>
        /// Example: CRAWL_NOT_FOUND
        /// </param>
        /// <param name="httpStatusCode">
        /// The corresponding HTTP status code.<br/>
        /// Example: 404
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsResponseStatuseError2(
            string? tag,
            int? httpStatusCode)
        {
            this.Tag = tag;
            this.HttpStatusCode = httpStatusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsResponseStatuseError2" /> class.
        /// </summary>
        public ContentsResponseStatuseError2()
        {
        }

    }
}