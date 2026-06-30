
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("institution_name")]
        public string? InstitutionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("degree")]
        public global::System.Collections.Generic.IList<string>? Degree { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public string? EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public string? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_timestamp")]
        public double? StartTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_timestamp")]
        public double? EndTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_months")]
        public double? DurationMonths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedin_url")]
        public string? LinkedinUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem" /> class.
        /// </summary>
        /// <param name="institutionName"></param>
        /// <param name="description"></param>
        /// <param name="degree"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="duration"></param>
        /// <param name="startTimestamp"></param>
        /// <param name="endTimestamp"></param>
        /// <param name="durationMonths"></param>
        /// <param name="linkedinUrl"></param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem(
            string? institutionName,
            string? description,
            global::System.Collections.Generic.IList<string>? degree,
            string? startTime,
            string? endTime,
            string? duration,
            double? startTimestamp,
            double? endTimestamp,
            double? durationMonths,
            string? linkedinUrl,
            string? imageUrl)
        {
            this.InstitutionName = institutionName;
            this.Description = description;
            this.Degree = degree;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Duration = duration;
            this.StartTimestamp = startTimestamp;
            this.EndTimestamp = endTimestamp;
            this.DurationMonths = durationMonths;
            this.LinkedinUrl = linkedinUrl;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant3ContentEducationItem()
        {
        }

    }
}