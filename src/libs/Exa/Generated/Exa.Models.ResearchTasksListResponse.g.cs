
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchTasksListResponse
    {
        /// <summary>
        /// Unique identifier for the request<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The list of research tasks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchTaskDto>? Data { get; set; }

        /// <summary>
        /// Whether there are more results to paginate through
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasMore")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// The cursor to paginate through the next set of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextCursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTasksListResponse" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique identifier for the request<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
        /// <param name="data">
        /// The list of research tasks
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more results to paginate through
        /// </param>
        /// <param name="nextCursor">
        /// The cursor to paginate through the next set of results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchTasksListResponse(
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.ResearchTaskDto>? data,
            bool? hasMore,
            string? nextCursor)
        {
            this.RequestId = requestId;
            this.Data = data;
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTasksListResponse" /> class.
        /// </summary>
        public ResearchTasksListResponse()
        {
        }
    }
}