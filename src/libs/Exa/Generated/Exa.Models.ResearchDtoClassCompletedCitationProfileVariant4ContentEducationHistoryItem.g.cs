
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("degree")]
        public string? Degree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("institution_url")]
        public string? InstitutionUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("institution_name")]
        public string? InstitutionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("institution_location")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItemInstitutionLocation? InstitutionLocation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_from_year")]
        public double? DateFromYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_to_year")]
        public double? DateToYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activities_and_societies")]
        public string? ActivitiesAndSocieties { get; set; }

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
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem" /> class.
        /// </summary>
        /// <param name="degree"></param>
        /// <param name="description"></param>
        /// <param name="institutionUrl"></param>
        /// <param name="institutionName"></param>
        /// <param name="institutionLocation"></param>
        /// <param name="dateFromYear"></param>
        /// <param name="dateToYear"></param>
        /// <param name="activitiesAndSocieties"></param>
        /// <param name="orderInProfile"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem(
            string? degree,
            string? description,
            string? institutionUrl,
            string? institutionName,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItemInstitutionLocation? institutionLocation,
            double? dateFromYear,
            double? dateToYear,
            string? activitiesAndSocieties,
            double? orderInProfile)
        {
            this.Degree = degree;
            this.Description = description;
            this.InstitutionUrl = institutionUrl;
            this.InstitutionName = institutionName;
            this.InstitutionLocation = institutionLocation;
            this.DateFromYear = dateFromYear;
            this.DateToYear = dateToYear;
            this.ActivitiesAndSocieties = activitiesAndSocieties;
            this.OrderInProfile = orderInProfile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem()
        {
        }

    }
}