
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2PlanOperationDataCrawl
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawlType Type { get; set; }

        /// <summary>
        /// What information the AI expects to find on this page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goal")]
        public string? Goal { get; set; }

        /// <summary>
        /// The specific page that was crawled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawlResult Result { get; set; }

        /// <summary>
        /// Token cost for processing the full page content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PageTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOperationDataCrawl" /> class.
        /// </summary>
        /// <param name="result">
        /// The specific page that was crawled
        /// </param>
        /// <param name="pageTokens">
        /// Token cost for processing the full page content
        /// </param>
        /// <param name="type"></param>
        /// <param name="goal">
        /// What information the AI expects to find on this page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant2PlanOperationDataCrawl(
            global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawlResult result,
            double pageTokens,
            global::Exa.ResearchEventDtoClassVariant2PlanOperationDataCrawlType type,
            string? goal)
        {
            this.Type = type;
            this.Goal = goal;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.PageTokens = pageTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOperationDataCrawl" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2PlanOperationDataCrawl()
        {
        }

    }
}