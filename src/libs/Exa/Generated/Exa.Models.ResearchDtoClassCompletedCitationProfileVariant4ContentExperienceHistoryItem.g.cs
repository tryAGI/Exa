
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position_title")]
        public string? PositionTitle { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompany? Company { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_in_profile")]
        public double? OrderInProfile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem" /> class.
        /// </summary>
        /// <param name="isActive"></param>
        /// <param name="positionTitle"></param>
        /// <param name="description"></param>
        /// <param name="department"></param>
        /// <param name="managementLevel"></param>
        /// <param name="location"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="durationMonths"></param>
        /// <param name="company"></param>
        /// <param name="orderInProfile"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem(
            bool? isActive,
            string? positionTitle,
            string? description,
            string? department,
            string? managementLevel,
            string? location,
            global::System.DateTime? dateFrom,
            global::System.DateTime? dateTo,
            double? durationMonths,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItemCompany? company,
            double? orderInProfile)
        {
            this.IsActive = isActive;
            this.PositionTitle = positionTitle;
            this.Description = description;
            this.Department = department;
            this.ManagementLevel = managementLevel;
            this.Location = location;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.DurationMonths = durationMonths;
            this.Company = company;
            this.OrderInProfile = orderInProfile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem()
        {
        }

    }
}