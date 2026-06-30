
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("management_level")]
        public string? ManagementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("months")]
        public double? Months { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem" /> class.
        /// </summary>
        /// <param name="managementLevel"></param>
        /// <param name="months"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem(
            string? managementLevel,
            double? months)
        {
            this.ManagementLevel = managementLevel;
            this.Months = months;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentExperienceDurationByManagementLevelItem()
        {
        }

    }
}