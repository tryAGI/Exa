
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewBreakdown
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("business_outlook")]
        public double? BusinessOutlook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("career_opportunities")]
        public double? CareerOpportunities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ceo_approval")]
        public double? CeoApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compensation_benefits")]
        public double? CompensationBenefits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("culture_values")]
        public double? CultureValues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diversity_inclusion")]
        public double? DiversityInclusion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommend")]
        public double? Recommend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("senior_management")]
        public double? SeniorManagement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("work_life_balance")]
        public double? WorkLifeBalance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewBreakdown" /> class.
        /// </summary>
        /// <param name="businessOutlook"></param>
        /// <param name="careerOpportunities"></param>
        /// <param name="ceoApproval"></param>
        /// <param name="compensationBenefits"></param>
        /// <param name="cultureValues"></param>
        /// <param name="diversityInclusion"></param>
        /// <param name="recommend"></param>
        /// <param name="seniorManagement"></param>
        /// <param name="workLifeBalance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewBreakdown(
            double? businessOutlook,
            double? careerOpportunities,
            double? ceoApproval,
            double? compensationBenefits,
            double? cultureValues,
            double? diversityInclusion,
            double? recommend,
            double? seniorManagement,
            double? workLifeBalance)
        {
            this.BusinessOutlook = businessOutlook;
            this.CareerOpportunities = careerOpportunities;
            this.CeoApproval = ceoApproval;
            this.CompensationBenefits = compensationBenefits;
            this.CultureValues = cultureValues;
            this.DiversityInclusion = diversityInclusion;
            this.Recommend = recommend;
            this.SeniorManagement = seniorManagement;
            this.WorkLifeBalance = workLifeBalance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewBreakdown" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1CustomersEmployerReviewBreakdown()
        {
        }

    }
}