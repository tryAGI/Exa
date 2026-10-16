
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchStreamDoneChunkOutput
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"done"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "done";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Exa.SearchSynthesisOutputOutput? Output { get; set; }

        /// <summary>
        /// Server-side processing time in milliseconds. May exclude output synthesis time, so it can be lower than end-to-end latency.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SearchTime { get; set; }

        /// <summary>
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::Exa.CostDollarsOutput? CostDollars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamDoneChunkOutput" /> class.
        /// </summary>
        /// <param name="searchTime">
        /// Server-side processing time in milliseconds. May exclude output synthesis time, so it can be lower than end-to-end latency.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="output"></param>
        /// <param name="costDollars">
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </param>
        /// <param name="choices"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamDoneChunkOutput(
            double searchTime,
            string? requestId,
            global::Exa.SearchSynthesisOutputOutput? output,
            global::Exa.CostDollarsOutput? costDollars,
            global::System.Collections.Generic.IList<global::Exa.SearchStreamDoneChunkOutputChoice>? choices,
            string type = "done")
        {
            this.RequestId = requestId;
            this.Type = type;
            this.Output = output;
            this.SearchTime = searchTime;
            this.CostDollars = costDollars;
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamDoneChunkOutput" /> class.
        /// </summary>
        public SearchStreamDoneChunkOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SearchStreamDoneChunkOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SearchStreamDoneChunkOutput FromSearchTime(double searchTime)
        {
            return new SearchStreamDoneChunkOutput
            {
                SearchTime = searchTime,
            };
        }

    }
}