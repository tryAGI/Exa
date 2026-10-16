
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchStreamResultsChunkOutput
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"results"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "results";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutput> Results { get; set; }

        /// <summary>
        /// Warnings about the request, such as a field that has no effect. Log them; do not pass them to a model. Omitted when there are none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<global::Exa.SearchWarningOutput>? Warnings { get; set; }

        /// <summary>
        /// Notices about how the results were produced. Pass them to your model with the results. Omitted when there are none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notices")]
        public global::System.Collections.Generic.IList<global::Exa.SearchNoticeOutput>? Notices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamResultsChunkOutput" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="warnings">
        /// Warnings about the request, such as a field that has no effect. Log them; do not pass them to a model. Omitted when there are none.
        /// </param>
        /// <param name="notices">
        /// Notices about how the results were produced. Pass them to your model with the results. Omitted when there are none.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamResultsChunkOutput(
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutput> results,
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.SearchWarningOutput>? warnings,
            global::System.Collections.Generic.IList<global::Exa.SearchNoticeOutput>? notices,
            string type = "results")
        {
            this.RequestId = requestId;
            this.Type = type;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Warnings = warnings;
            this.Notices = notices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamResultsChunkOutput" /> class.
        /// </summary>
        public SearchStreamResultsChunkOutput()
        {
        }

    }
}