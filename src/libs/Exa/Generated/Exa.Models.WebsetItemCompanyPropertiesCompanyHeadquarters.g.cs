
#nullable enable

namespace Exa
{
    /// <summary>
    /// The structured headquarters address of the company
    /// </summary>
    public sealed partial class WebsetItemCompanyPropertiesCompanyHeadquarters
    {
        /// <summary>
        /// The street address of the headquarters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// The city of the headquarters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The state or region of the headquarters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// The postal code of the headquarters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// The country of the headquarters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The ISO country code of the headquarters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryCode")]
        public string? CountryCode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompanyHeadquarters" /> class.
        /// </summary>
        /// <param name="address">
        /// The street address of the headquarters
        /// </param>
        /// <param name="city">
        /// The city of the headquarters
        /// </param>
        /// <param name="state">
        /// The state or region of the headquarters
        /// </param>
        /// <param name="postalCode">
        /// The postal code of the headquarters
        /// </param>
        /// <param name="country">
        /// The country of the headquarters
        /// </param>
        /// <param name="countryCode">
        /// The ISO country code of the headquarters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemCompanyPropertiesCompanyHeadquarters(
            string? address,
            string? city,
            string? state,
            string? postalCode,
            string? country,
            string? countryCode)
        {
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PostalCode = postalCode;
            this.Country = country;
            this.CountryCode = countryCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyPropertiesCompanyHeadquarters" /> class.
        /// </summary>
        public WebsetItemCompanyPropertiesCompanyHeadquarters()
        {
        }

    }
}