
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListResearchResponseDto
    {
        /// <summary>
        /// Research requests ordered by creation time (newest first)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.ResearchDtoClass> Data { get; set; }

        /// <summary>
        /// If true, use nextCursor to fetch more results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Pass this value as the cursor parameter to fetch the next page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResearchResponseDto" /> class.
        /// </summary>
        /// <param name="data">
        /// Research requests ordered by creation time (newest first)
        /// </param>
        /// <param name="hasMore">
        /// If true, use nextCursor to fetch more results
        /// </param>
        /// <param name="nextCursor">
        /// Pass this value as the cursor parameter to fetch the next page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListResearchResponseDto(
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClass> data,
            bool hasMore,
            string? nextCursor)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResearchResponseDto" /> class.
        /// </summary>
        public ListResearchResponseDto()
        {
        }

    }
}