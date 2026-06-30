
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        public double? Followers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions_count")]
        public double? ReactionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_count")]
        public double? CommentsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reshared_post_author")]
        public string? ResharedPostAuthor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reshared_post_author_url")]
        public string? ResharedPostAuthorUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reshared_post_author_headline")]
        public string? ResharedPostAuthorHeadline { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reshared_post_description")]
        public string? ResharedPostDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reshared_post_date")]
        public string? ResharedPostDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reshared_post_followers")]
        public double? ResharedPostFollowers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate" /> class.
        /// </summary>
        /// <param name="followers"></param>
        /// <param name="date"></param>
        /// <param name="description"></param>
        /// <param name="reactionsCount"></param>
        /// <param name="commentsCount"></param>
        /// <param name="resharedPostAuthor"></param>
        /// <param name="resharedPostAuthorUrl"></param>
        /// <param name="resharedPostAuthorHeadline"></param>
        /// <param name="resharedPostDescription"></param>
        /// <param name="resharedPostDate"></param>
        /// <param name="resharedPostFollowers"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate(
            double? followers,
            string? date,
            string? description,
            double? reactionsCount,
            double? commentsCount,
            string? resharedPostAuthor,
            string? resharedPostAuthorUrl,
            string? resharedPostAuthorHeadline,
            string? resharedPostDescription,
            string? resharedPostDate,
            double? resharedPostFollowers)
        {
            this.Followers = followers;
            this.Date = date;
            this.Description = description;
            this.ReactionsCount = reactionsCount;
            this.CommentsCount = commentsCount;
            this.ResharedPostAuthor = resharedPostAuthor;
            this.ResharedPostAuthorUrl = resharedPostAuthorUrl;
            this.ResharedPostAuthorHeadline = resharedPostAuthorHeadline;
            this.ResharedPostDescription = resharedPostDescription;
            this.ResharedPostDate = resharedPostDate;
            this.ResharedPostFollowers = resharedPostFollowers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1ProfilesUpdate()
        {
        }

    }
}