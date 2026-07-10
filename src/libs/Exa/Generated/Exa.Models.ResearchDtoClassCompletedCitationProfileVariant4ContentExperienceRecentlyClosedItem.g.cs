
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_id")]
        public string? CompanyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_name")]
        public string? CompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_url")]
        public string? CompanyUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_shorthand_name")]
        public string? CompanyShorthandName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identification_date")]
        public global::System.DateTime? IdentificationDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem" /> class.
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="companyName"></param>
        /// <param name="companyUrl"></param>
        /// <param name="companyShorthandName"></param>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="title"></param>
        /// <param name="identificationDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem(
            string? companyId,
            string? companyName,
            string? companyUrl,
            string? companyShorthandName,
            global::System.DateTime? dateFrom,
            global::System.DateTime? dateTo,
            string? title,
            global::System.DateTime? identificationDate)
        {
            this.CompanyId = companyId;
            this.CompanyName = companyName;
            this.CompanyUrl = companyUrl;
            this.CompanyShorthandName = companyShorthandName;
            this.DateFrom = dateFrom;
            this.DateTo = dateTo;
            this.Title = title;
            this.IdentificationDate = identificationDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem()
        {
        }

    }
}