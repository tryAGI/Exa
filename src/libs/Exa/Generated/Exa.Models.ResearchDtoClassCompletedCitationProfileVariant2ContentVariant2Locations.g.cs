
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Locations
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hq_city")]
        public string? HqCity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hq_country")]
        public string? HqCountry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headquarters")]
        public global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2LocationsHeadquarters? Headquarters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Locations" /> class.
        /// </summary>
        /// <param name="hqCity"></param>
        /// <param name="hqCountry"></param>
        /// <param name="headquarters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Locations(
            string? hqCity,
            string? hqCountry,
            global::Exa.ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2LocationsHeadquarters? headquarters)
        {
            this.HqCity = hqCity;
            this.HqCountry = hqCountry;
            this.Headquarters = headquarters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Locations" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant2ContentVariant2Locations()
        {
        }

    }
}