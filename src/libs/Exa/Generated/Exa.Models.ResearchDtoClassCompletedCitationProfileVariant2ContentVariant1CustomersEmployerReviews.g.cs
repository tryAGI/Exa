
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviews
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public double? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average_score")]
        public double? AverageScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_score")]
        public double? MaxScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribution")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsDistribution? Distribution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categories")]
        public global::System.Collections.Generic.Dictionary<string, double>? Categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trend")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsTrend? Trend { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviews" /> class.
        /// </summary>
        /// <param name="count"></param>
        /// <param name="averageScore"></param>
        /// <param name="maxScore"></param>
        /// <param name="distribution"></param>
        /// <param name="categories"></param>
        /// <param name="trend"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviews(
            double? count,
            double? averageScore,
            double? maxScore,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsDistribution? distribution,
            global::System.Collections.Generic.Dictionary<string, double>? categories,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsTrend? trend)
        {
            this.Count = count;
            this.AverageScore = averageScore;
            this.MaxScore = maxScore;
            this.Distribution = distribution;
            this.Categories = categories;
            this.Trend = trend;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviews" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviews()
        {
        }

    }
}