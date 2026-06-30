
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListWebsetItemResponse
    {
        /// <summary>
        /// The list of webset items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.WebsetItem> Data { get; set; }

        /// <summary>
        /// Whether there are more Items to paginate through
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The cursor to paginate through the next set of Items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebsetItemResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of webset items
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more Items to paginate through
        /// </param>
        /// <param name="nextCursor">
        /// The cursor to paginate through the next set of Items
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWebsetItemResponse(
            global::System.Collections.Generic.IList<global::Exa.WebsetItem> data,
            bool hasMore,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWebsetItemResponse" /> class.
        /// </summary>
        public ListWebsetItemResponse()
        {
        }

    }
}