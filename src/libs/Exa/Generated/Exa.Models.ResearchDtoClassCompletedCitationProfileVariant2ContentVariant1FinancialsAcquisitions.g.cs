
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acquired_by")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquiredBy? AcquiredBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acquisitions")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition>? Acquisitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("investments")]
        public global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsInvestment>? Investments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_acquisitions")]
        public double? TotalAcquisitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_invested")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsTotalInvested? TotalInvested { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitions" /> class.
        /// </summary>
        /// <param name="acquiredBy"></param>
        /// <param name="acquisitions"></param>
        /// <param name="investments"></param>
        /// <param name="totalAcquisitions"></param>
        /// <param name="totalInvested"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitions(
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquiredBy? acquiredBy,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsAcquisition>? acquisitions,
            global::System.Collections.Generic.IList<global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsInvestment>? investments,
            double? totalAcquisitions,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitionsTotalInvested? totalInvested)
        {
            this.AcquiredBy = acquiredBy;
            this.Acquisitions = acquisitions;
            this.Investments = investments;
            this.TotalAcquisitions = totalAcquisitions;
            this.TotalInvested = totalInvested;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitions" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant1FinancialsAcquisitions()
        {
        }

    }
}