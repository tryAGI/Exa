
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchStreamChunkVariant5
    {
        /// <summary>
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </summary>
        /// <example>b5947044c4b78efa9552a7c89b306d95</example>
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SearchTime { get; set; }

        /// <summary>
        /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::Exa.CostDollarsOutput? CostDollars { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant5Choice>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStreamChunkVariant5" /> class.
        /// </summary>
        /// <param name="searchTime"></param>
        /// <param name="requestId">
        /// Unique identifier for the request.<br/>
        /// Example: b5947044c4b78efa9552a7c89b306d95
        /// </param>
        /// <param name="output"></param>
        /// <param name="costDollars">
        /// Endpoint-dependent estimated dollar cost breakdown for the completed request. Billing is computed from usage counters rather than this response object.
        /// </param>
        /// <param name="choices"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchStreamChunkVariant5(
            double searchTime,
            string? requestId,
            global::Exa.SearchSynthesisOutputOutput? output,
            global::Exa.CostDollarsOutput? costDollars,
            global::System.Collections.Generic.IList<global::Exa.SearchStreamChunkVariant5Choice>? choices,
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
        /// Initializes a new instance of the <see cref="SearchStreamChunkVariant5" /> class.
        /// </summary>
        public SearchStreamChunkVariant5()
        {
        }

        /// <summary>
        /// Creates a new <see cref="SearchStreamChunkVariant5"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static SearchStreamChunkVariant5 FromSearchTime(double searchTime)
        {
            return new SearchStreamChunkVariant5
            {
                SearchTime = searchTime,
            };
        }

    }
}