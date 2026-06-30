
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceActive
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_id")]
        public double? CompanyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("department")]
        public string? Department { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("management_level")]
        public string? ManagementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_from")]
        public global::System.DateTime? DateFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_to")]
        public global::System.DateTime? DateTo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_months")]
        public double? DurationMonths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceActive" /> class.
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="department"></param>
        /// <param name="managementLevel"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="durationMonths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceActive(
            double? companyId,
            string? title,
            string? description,
            string? department,
            string? managementLevel,
            global::System.DateTime? dateFrom,
            global::System.DateTime? dateTo,
            double? durationMonths)
        {
            this.CompanyId = companyId;
            this.Title = title;
            this.Description = description;
            this.Department = department;
            this.ManagementLevel = managementLevel;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.DurationMonths = durationMonths;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceActive" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceActive()
        {
        }

    }
}