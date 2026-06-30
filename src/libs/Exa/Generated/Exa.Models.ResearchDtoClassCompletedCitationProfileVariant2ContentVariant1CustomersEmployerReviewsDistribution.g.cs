
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsDistribution
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_1")]
        public double? Score1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_2")]
        public double? Score2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_3")]
        public double? Score3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_4")]
        public double? Score4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_5")]
        public double? Score5 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsDistribution" /> class.
        /// </summary>
        /// <param name="score1"></param>
        /// <param name="score2"></param>
        /// <param name="score3"></param>
        /// <param name="score4"></param>
        /// <param name="score5"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsDistribution(
            double? score1,
            double? score2,
            double? score3,
            double? score4,
            double? score5)
        {
            this.Score1 = score1;
            this.Score2 = score2;
            this.Score3 = score3;
            this.Score4 = score4;
            this.Score5 = score5;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsDistribution" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewsDistribution()
        {
        }

    }
}