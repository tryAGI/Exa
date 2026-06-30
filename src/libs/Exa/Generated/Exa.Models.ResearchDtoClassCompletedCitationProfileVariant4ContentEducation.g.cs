
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentEducation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_graduation_year")]
        public double? LastGraduationYear { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("degrees")]
        public global::System.Collections.Generic.IList<string>? Degrees { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem>? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentEducation" /> class.
        /// </summary>
        /// <param name="lastGraduationYear"></param>
        /// <param name="degrees"></param>
        /// <param name="history"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentEducation(
            double? lastGraduationYear,
            global::System.Collections.Generic.IList<string>? degrees,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItem>? history)
        {
            this.LastGraduationYear = lastGraduationYear;
            this.Degrees = degrees;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentEducation" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentEducation()
        {
        }

    }
}