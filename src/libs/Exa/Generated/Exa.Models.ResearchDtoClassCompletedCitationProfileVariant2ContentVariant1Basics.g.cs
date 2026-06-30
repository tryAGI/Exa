
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Basics
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_enriched")]
        public string? DescriptionEnriched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slogan")]
        public string? Slogan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("founded_year")]
        public double? FoundedYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownership_status")]
        public string? OwnershipStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_company_name")]
        public string? ParentCompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_company_website")]
        public string? ParentCompanyWebsite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_changed")]
        public string? LastChanged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Basics" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="descriptionEnriched"></param>
        /// <param name="slogan"></param>
        /// <param name="foundedYear"></param>
        /// <param name="status"></param>
        /// <param name="ownershipStatus"></param>
        /// <param name="parentCompanyName"></param>
        /// <param name="parentCompanyWebsite"></param>
        /// <param name="lastChanged"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Basics(
            string? description,
            string? descriptionEnriched,
            string? slogan,
            double? foundedYear,
            string? status,
            string? ownershipStatus,
            string? parentCompanyName,
            string? parentCompanyWebsite,
            string? lastChanged)
        {
            this.Description = description;
            this.DescriptionEnriched = descriptionEnriched;
            this.Slogan = slogan;
            this.FoundedYear = foundedYear;
            this.Status = status;
            this.OwnershipStatus = ownershipStatus;
            this.ParentCompanyName = parentCompanyName;
            this.ParentCompanyWebsite = parentCompanyWebsite;
            this.LastChanged = lastChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Basics" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Basics()
        {
        }

    }
}