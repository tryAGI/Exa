
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItemInstitutionLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_address")]
        public string? FullAddress { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("regions")]
        public global::System.Collections.Generic.IList<string>? Regions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("street")]
        public string? Street { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zipcode")]
        public string? Zipcode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItemInstitutionLocation" /> class.
        /// </summary>
        /// <param name="fullAddress"></param>
        /// <param name="countryIso2"></param>
        /// <param name="countryIso3"></param>
        /// <param name="regions"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="street"></param>
        /// <param name="zipcode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItemInstitutionLocation(
            string? fullAddress,
            string? countryIso2,
            string? countryIso3,
            global::System.Collections.Generic.IList<string>? regions,
            string? city,
            string? state,
            string? street,
            string? zipcode)
        {
            this.FullAddress = fullAddress;
            this.CountryIso2 = countryIso2;
            this.CountryIso3 = countryIso3;
            this.Regions = regions;
            this.City = city;
            this.State = state;
            this.Street = street;
            this.Zipcode = zipcode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItemInstitutionLocation" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentEducationHistoryItemInstitutionLocation()
        {
        }

    }
}