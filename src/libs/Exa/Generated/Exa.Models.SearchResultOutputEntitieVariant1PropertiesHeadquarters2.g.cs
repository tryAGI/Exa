
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesHeadquarters2
    {
        /// <summary>
        /// Company headquarters street address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Company headquarters city.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Company headquarters postal code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("postalCode")]
        public string? PostalCode { get; set; }

        /// <summary>
        /// Company headquarters country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesHeadquarters2" /> class.
        /// </summary>
        /// <param name="address">
        /// Company headquarters street address.
        /// </param>
        /// <param name="city">
        /// Company headquarters city.
        /// </param>
        /// <param name="postalCode">
        /// Company headquarters postal code.
        /// </param>
        /// <param name="country">
        /// Company headquarters country.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesHeadquarters2(
            string? address,
            string? city,
            string? postalCode,
            string? country)
        {
            this.Address = address;
            this.City = city;
            this.PostalCode = postalCode;
            this.Country = country;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesHeadquarters2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesHeadquarters2()
        {
        }

    }
}