
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_iso2")]
        public string? CountryIso2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country_iso3")]
        public string? CountryIso3 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full")]
        public string? Full { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string>? Regions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentLocation" /> class.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="countryIso2"></param>
        /// <param name="countryIso3"></param>
        /// <param name="full"></param>
        /// <param name="regions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentLocation(
            string? country,
            string? countryIso2,
            string? countryIso3,
            string? full,
            global::System.Collections.Generic.IList<string>? regions)
        {
            this.Country = country;
            this.CountryIso2 = countryIso2;
            this.CountryIso3 = countryIso3;
            this.Full = full;
            this.Regions = regions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentLocation" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentLocation()
        {
        }

    }
}