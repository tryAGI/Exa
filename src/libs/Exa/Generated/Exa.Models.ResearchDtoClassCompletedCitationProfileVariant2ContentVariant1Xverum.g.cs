
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Xverum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company_id")]
        public double? CompanyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        public string? ProfileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_followers")]
        public double? SocialFollowers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image_url")]
        public string? CoverImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        public string? SchemaVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_month")]
        public string? UpdatedMonth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Xverum" /> class.
        /// </summary>
        /// <param name="companyId"></param>
        /// <param name="profileId"></param>
        /// <param name="socialFollowers"></param>
        /// <param name="imageUrl"></param>
        /// <param name="coverImageUrl"></param>
        /// <param name="schemaVersion"></param>
        /// <param name="updatedMonth"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Xverum(
            double? companyId,
            string? profileId,
            double? socialFollowers,
            string? imageUrl,
            string? coverImageUrl,
            string? schemaVersion,
            string? updatedMonth)
        {
            this.CompanyId = companyId;
            this.ProfileId = profileId;
            this.SocialFollowers = socialFollowers;
            this.ImageUrl = imageUrl;
            this.CoverImageUrl = coverImageUrl;
            this.SchemaVersion = schemaVersion;
            this.UpdatedMonth = updatedMonth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Xverum" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1Xverum()
        {
        }

    }
}