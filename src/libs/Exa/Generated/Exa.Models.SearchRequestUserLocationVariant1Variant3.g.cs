
#nullable enable

namespace Exa
{
    /// <summary>
    /// The user's coordinates, with an optional country.
    /// </summary>
    public sealed partial class SearchRequestUserLocationVariant1Variant3
    {
        /// <summary>
        /// The two-letter ISO 3166-1 country code of the user, e.g. `US`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The user's latitude in decimal degrees.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Latitude { get; set; }

        /// <summary>
        /// The user's longitude in decimal degrees.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longitude")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Longitude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestUserLocationVariant1Variant3" /> class.
        /// </summary>
        /// <param name="latitude">
        /// The user's latitude in decimal degrees.
        /// </param>
        /// <param name="longitude">
        /// The user's longitude in decimal degrees.
        /// </param>
        /// <param name="country">
        /// The two-letter ISO 3166-1 country code of the user, e.g. `US`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestUserLocationVariant1Variant3(
            double latitude,
            double longitude,
            string? country)
        {
            this.Country = country;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestUserLocationVariant1Variant3" /> class.
        /// </summary>
        public SearchRequestUserLocationVariant1Variant3()
        {
        }

    }
}