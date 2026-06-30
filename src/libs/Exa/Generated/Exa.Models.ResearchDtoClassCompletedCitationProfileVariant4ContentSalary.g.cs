
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentSalary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryBase? Base { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditional? Additional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryTotal? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentSalary" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="additional"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentSalary(
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryBase? @base,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryAdditional? additional,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant4ContentSalaryTotal? total)
        {
            this.Base = @base;
            this.Additional = additional;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentSalary" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentSalary()
        {
        }

    }
}