
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentExperience
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_working")]
        public bool? IsWorking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_decision_maker")]
        public bool? IsDecisionMaker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceActive? Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_months")]
        public double? TotalDurationMonths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_by_department")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByDepartmentItem>? DurationByDepartment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_by_management_level")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem>? DurationByManagementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem>? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperience" /> class.
        /// </summary>
        /// <param name="isWorking"></param>
        /// <param name="isDecisionMaker"></param>
        /// <param name="active"></param>
        /// <param name="totalDurationMonths"></param>
        /// <param name="durationByDepartment"></param>
        /// <param name="durationByManagementLevel"></param>
        /// <param name="history"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperience(
            bool? isWorking,
            bool? isDecisionMaker,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceActive? active,
            double? totalDurationMonths,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByDepartmentItem>? durationByDepartment,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem>? durationByManagementLevel,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceHistoryItem>? history)
        {
            this.IsWorking = isWorking;
            this.IsDecisionMaker = isDecisionMaker;
            this.Active = active;
            this.TotalDurationMonths = totalDurationMonths;
            this.DurationByDepartment = durationByDepartment;
            this.DurationByManagementLevel = durationByManagementLevel;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperience" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperience()
        {
        }

    }
}