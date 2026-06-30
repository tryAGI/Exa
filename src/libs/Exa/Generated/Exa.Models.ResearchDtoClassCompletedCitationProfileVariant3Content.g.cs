
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant3Content
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public string? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_code")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("about_me")]
        public string? AboutMe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections")]
        public double? Connections { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        public string? Followers { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("websites")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentWebsite> Websites { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentExperienceItem> Experience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("education")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem> Education { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certifications")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentCertification> Certifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patents")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPatent>? Patents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awards")]
        public global::System.Collections.Generic.IList<string>? Awards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volunteering")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentVolunteeringItem>? Volunteering { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentProject>? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentLanguage>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publications")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPublication>? Publications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendations")]
        public global::System.Collections.Generic.IList<string>? Recommendations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_activities")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialActivitie>? SocialActivities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("courses")]
        public global::System.Collections.Generic.IList<string>? Courses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_groups")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialGroup>? SocialGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentMetaData MetaData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant3Content" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fullName"></param>
        /// <param name="websites"></param>
        /// <param name="experience"></param>
        /// <param name="education"></param>
        /// <param name="certifications"></param>
        /// <param name="metaData"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="position"></param>
        /// <param name="location"></param>
        /// <param name="countryCode"></param>
        /// <param name="aboutMe"></param>
        /// <param name="connections"></param>
        /// <param name="followers"></param>
        /// <param name="imageUrl"></param>
        /// <param name="coverImageUrl"></param>
        /// <param name="patents"></param>
        /// <param name="awards"></param>
        /// <param name="volunteering"></param>
        /// <param name="projects"></param>
        /// <param name="languages"></param>
        /// <param name="publications"></param>
        /// <param name="recommendations"></param>
        /// <param name="socialActivities"></param>
        /// <param name="courses"></param>
        /// <param name="socialGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant3Content(
            string url,
            string fullName,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentWebsite> websites,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentExperienceItem> experience,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem> education,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentCertification> certifications,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentMetaData metaData,
            string? firstName,
            string? lastName,
            string? position,
            string? location,
            string? countryCode,
            string? aboutMe,
            double? connections,
            string? followers,
            string? imageUrl,
            string? coverImageUrl,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPatent>? patents,
            global::System.Collections.Generic.IList<string>? awards,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentVolunteeringItem>? volunteering,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentProject>? projects,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentLanguage>? languages,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentPublication>? publications,
            global::System.Collections.Generic.IList<string>? recommendations,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialActivitie>? socialActivities,
            global::System.Collections.Generic.IList<string>? courses,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant3ContentSocialGroup>? socialGroups)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.FullName = fullName ?? throw new global::System.ArgumentNullException(nameof(fullName));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Position = position;
            this.Location = location;
            this.CountryCode = countryCode;
            this.AboutMe = aboutMe;
            this.Connections = connections;
            this.Followers = followers;
            this.ImageUrl = imageUrl;
            this.CoverImageUrl = coverImageUrl;
            this.Websites = websites ?? throw new global::System.ArgumentNullException(nameof(websites));
            this.Experience = experience ?? throw new global::System.ArgumentNullException(nameof(experience));
            this.Education = education ?? throw new global::System.ArgumentNullException(nameof(education));
            this.Certifications = certifications ?? throw new global::System.ArgumentNullException(nameof(certifications));
            this.Patents = patents;
            this.Awards = awards;
            this.Volunteering = volunteering;
            this.Projects = projects;
            this.Languages = languages;
            this.Publications = publications;
            this.Recommendations = recommendations;
            this.SocialActivities = socialActivities;
            this.Courses = courses;
            this.SocialGroups = socialGroups;
            this.MetaData = metaData ?? throw new global::System.ArgumentNullException(nameof(metaData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant3Content" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant3Content()
        {
        }

    }
}