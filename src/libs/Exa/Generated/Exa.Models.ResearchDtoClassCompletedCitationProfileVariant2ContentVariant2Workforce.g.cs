
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Workforce
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public double? TotalCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count_inferred")]
        public double? TotalCountInferred { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("growth")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2WorkforceGrowth? Growth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_range")]
        public string? SizeRange { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Workforce" /> class.
        /// </summary>
        /// <param name="totalCount"></param>
        /// <param name="totalCountInferred"></param>
        /// <param name="growth"></param>
        /// <param name="sizeRange"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Workforce(
            double? totalCount,
            double? totalCountInferred,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2WorkforceGrowth? growth,
            string? sizeRange)
        {
            this.TotalCount = totalCount;
            this.TotalCountInferred = totalCountInferred;
            this.Growth = growth;
            this.SizeRange = sizeRange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Workforce" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Workforce()
        {
        }

    }
}