
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p25")]
        public double? P25 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median")]
        public double? Median { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p75")]
        public double? P75 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="p25"></param>
        /// <param name="median"></param>
        /// <param name="p75"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem(
            string? type,
            double? p25,
            double? median,
            double? p75)
        {
            this.Type = type;
            this.P25 = p25;
            this.Median = median;
            this.P75 = p75;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditionalItem()
        {
        }

    }
}