
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4Content
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanonicalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publish_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cs_metadata")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCsMetadata? CsMetadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("middle_name")]
        public string? MiddleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedin_url")]
        public string? LinkedinUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedin_shorthand_names")]
        public global::System.Collections.Generic.IList<string>? LinkedinShorthandNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("historical_ids")]
        public global::System.Collections.Generic.IList<double>? HistoricalIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headline")]
        public string? Headline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture_url")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentLocation? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interests")]
        public global::System.Collections.Generic.IList<string>? Interests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferred_skills")]
        public global::System.Collections.Generic.IList<string>? InferredSkills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connections_count")]
        public double? ConnectionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_count")]
        public double? FollowersCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("services")]
        public string? Services { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contact")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContact? Contact { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experience")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperience? Experience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("salary")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalary? Salary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("education")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducation? Education { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendations_count")]
        public double? RecommendationsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recommendations")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentRecommendation>? Recommendations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentActivityItem>? Activity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("awards")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentAward>? Awards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("courses")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCourse>? Courses { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certifications")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCertification>? Certifications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentLanguage>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patents_count")]
        public double? PatentsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patents_topics")]
        public global::System.Collections.Generic.IList<string>? PatentsTopics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("patents")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPatent>? Patents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publications_count")]
        public double? PublicationsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publications_topics")]
        public global::System.Collections.Generic.IList<string>? PublicationsTopics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("publications")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPublication>? Publications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_count")]
        public double? ProjectsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_topics")]
        public global::System.Collections.Generic.IList<string>? ProjectsTopics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProject>? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentOrganization>? Organizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentGithub? Github { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_root_field_changes_summary")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem>? ProfileRootFieldChangesSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_collection_field_changes_summary")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileCollectionFieldChangesSummaryItem>? ProfileCollectionFieldChangesSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experience_recently_started")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyStartedItem>? ExperienceRecentlyStarted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experience_recently_closed")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem>? ExperienceRecentlyClosed { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchDtoClassCompletedCitationProfileVariant4ContentVersionJsonConverter))]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentVersion? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4Content" /> class.
        /// </summary>
        /// <param name="canonicalUrl"></param>
        /// <param name="publishTimestamp"></param>
        /// <param name="csMetadata"></param>
        /// <param name="fullName"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="linkedinUrl"></param>
        /// <param name="linkedinShorthandNames"></param>
        /// <param name="historicalIds"></param>
        /// <param name="headline"></param>
        /// <param name="summary"></param>
        /// <param name="pictureUrl"></param>
        /// <param name="location"></param>
        /// <param name="interests"></param>
        /// <param name="inferredSkills"></param>
        /// <param name="connectionsCount"></param>
        /// <param name="followersCount"></param>
        /// <param name="services"></param>
        /// <param name="contact"></param>
        /// <param name="experience"></param>
        /// <param name="salary"></param>
        /// <param name="education"></param>
        /// <param name="recommendationsCount"></param>
        /// <param name="recommendations"></param>
        /// <param name="activity"></param>
        /// <param name="awards"></param>
        /// <param name="courses"></param>
        /// <param name="certifications"></param>
        /// <param name="languages"></param>
        /// <param name="patentsCount"></param>
        /// <param name="patentsTopics"></param>
        /// <param name="patents"></param>
        /// <param name="publicationsCount"></param>
        /// <param name="publicationsTopics"></param>
        /// <param name="publications"></param>
        /// <param name="projectsCount"></param>
        /// <param name="projectsTopics"></param>
        /// <param name="projects"></param>
        /// <param name="organizations"></param>
        /// <param name="github"></param>
        /// <param name="profileRootFieldChangesSummary"></param>
        /// <param name="profileCollectionFieldChangesSummary"></param>
        /// <param name="experienceRecentlyStarted"></param>
        /// <param name="experienceRecentlyClosed"></param>
        /// <param name="version">
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4Content(
            string canonicalUrl,
            global::System.DateTime publishTimestamp,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCsMetadata? csMetadata,
            string? fullName,
            string? firstName,
            string? middleName,
            string? lastName,
            string? linkedinUrl,
            global::System.Collections.Generic.IList<string>? linkedinShorthandNames,
            global::System.Collections.Generic.IList<double>? historicalIds,
            string? headline,
            string? summary,
            string? pictureUrl,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentLocation? location,
            global::System.Collections.Generic.IList<string>? interests,
            global::System.Collections.Generic.IList<string>? inferredSkills,
            double? connectionsCount,
            double? followersCount,
            string? services,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentContact? contact,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperience? experience,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalary? salary,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducation? education,
            double? recommendationsCount,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentRecommendation>? recommendations,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentActivityItem>? activity,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentAward>? awards,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCourse>? courses,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentCertification>? certifications,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentLanguage>? languages,
            double? patentsCount,
            global::System.Collections.Generic.IList<string>? patentsTopics,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPatent>? patents,
            double? publicationsCount,
            global::System.Collections.Generic.IList<string>? publicationsTopics,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentPublication>? publications,
            double? projectsCount,
            global::System.Collections.Generic.IList<string>? projectsTopics,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProject>? projects,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentOrganization>? organizations,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentGithub? github,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem>? profileRootFieldChangesSummary,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentProfileCollectionFieldChangesSummaryItem>? profileCollectionFieldChangesSummary,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyStartedItem>? experienceRecentlyStarted,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceRecentlyClosedItem>? experienceRecentlyClosed,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentVersion? version)
        {
            this.CanonicalUrl = canonicalUrl ?? throw new global::System.ArgumentNullException(nameof(canonicalUrl));
            this.PublishTimestamp = publishTimestamp;
            this.CsMetadata = csMetadata;
            this.FullName = fullName;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.LinkedinUrl = linkedinUrl;
            this.LinkedinShorthandNames = linkedinShorthandNames;
            this.HistoricalIds = historicalIds;
            this.Headline = headline;
            this.Summary = summary;
            this.PictureUrl = pictureUrl;
            this.Location = location;
            this.Interests = interests;
            this.InferredSkills = inferredSkills;
            this.ConnectionsCount = connectionsCount;
            this.FollowersCount = followersCount;
            this.Services = services;
            this.Contact = contact;
            this.Experience = experience;
            this.Salary = salary;
            this.Education = education;
            this.RecommendationsCount = recommendationsCount;
            this.Recommendations = recommendations;
            this.Activity = activity;
            this.Awards = awards;
            this.Courses = courses;
            this.Certifications = certifications;
            this.Languages = languages;
            this.PatentsCount = patentsCount;
            this.PatentsTopics = patentsTopics;
            this.Patents = patents;
            this.PublicationsCount = publicationsCount;
            this.PublicationsTopics = publicationsTopics;
            this.Publications = publications;
            this.ProjectsCount = projectsCount;
            this.ProjectsTopics = projectsTopics;
            this.Projects = projects;
            this.Organizations = organizations;
            this.Github = github;
            this.ProfileRootFieldChangesSummary = profileRootFieldChangesSummary;
            this.ProfileCollectionFieldChangesSummary = profileCollectionFieldChangesSummary;
            this.ExperienceRecentlyStarted = experienceRecentlyStarted;
            this.ExperienceRecentlyClosed = experienceRecentlyClosed;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4Content" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4Content()
        {
        }

    }
}