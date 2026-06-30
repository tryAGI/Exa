
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Customers
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_count")]
        public double? CustomerCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_segments")]
        public global::System.Collections.Generic.IList<string>? CustomerSegments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_reviews")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersProductReviews? ProductReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("employer_reviews")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviews? EmployerReviews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("employer_review_breakdown")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewBreakdown? EmployerReviewBreakdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nps_score")]
        public double? NpsScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Customers" /> class.
        /// </summary>
        /// <param name="customerCount"></param>
        /// <param name="customerSegments"></param>
        /// <param name="productReviews"></param>
        /// <param name="employerReviews"></param>
        /// <param name="employerReviewBreakdown"></param>
        /// <param name="npsScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Customers(
            double? customerCount,
            global::System.Collections.Generic.IList<string>? customerSegments,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersProductReviews? productReviews,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviews? employerReviews,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewBreakdown? employerReviewBreakdown,
            double? npsScore)
        {
            this.CustomerCount = customerCount;
            this.CustomerSegments = customerSegments;
            this.ProductReviews = productReviews;
            this.EmployerReviews = employerReviews;
            this.EmployerReviewBreakdown = employerReviewBreakdown;
            this.NpsScore = npsScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Customers" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Customers()
        {
        }

    }
}