
#nullable enable

namespace Exa
{
    /// <summary>
    /// Company-specific entity fields.
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1Properties
    {
        /// <summary>
        /// Company name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Year the company was founded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("foundedYear")]
        public int? FoundedYear { get; set; }

        /// <summary>
        /// Short company description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Company workforce information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workforce")]
        public global::Exa.SearchResultOutputEntitieVariant1PropertiesWorkforce2? Workforce { get; set; }

        /// <summary>
        /// Company headquarters information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headquarters")]
        public global::Exa.SearchResultOutputEntitieVariant1PropertiesHeadquarters2? Headquarters { get; set; }

        /// <summary>
        /// Company financial information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("financials")]
        public global::Exa.SearchResultOutputEntitieVariant1PropertiesFinancials2? Financials { get; set; }

        /// <summary>
        /// Company web traffic information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webTraffic")]
        public global::Exa.SearchResultOutputEntitieVariant1PropertiesWebTraffic2? WebTraffic { get; set; }

        /// <summary>
        /// Company research information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("research")]
        public global::Exa.SearchResultOutputEntitieVariant1PropertiesResearch2? Research { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1Properties" /> class.
        /// </summary>
        /// <param name="name">
        /// Company name.
        /// </param>
        /// <param name="foundedYear">
        /// Year the company was founded.
        /// </param>
        /// <param name="description">
        /// Short company description.
        /// </param>
        /// <param name="workforce">
        /// Company workforce information.
        /// </param>
        /// <param name="headquarters">
        /// Company headquarters information.
        /// </param>
        /// <param name="financials">
        /// Company financial information.
        /// </param>
        /// <param name="webTraffic">
        /// Company web traffic information.
        /// </param>
        /// <param name="research">
        /// Company research information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1Properties(
            string? name,
            int? foundedYear,
            string? description,
            global::Exa.SearchResultOutputEntitieVariant1PropertiesWorkforce2? workforce,
            global::Exa.SearchResultOutputEntitieVariant1PropertiesHeadquarters2? headquarters,
            global::Exa.SearchResultOutputEntitieVariant1PropertiesFinancials2? financials,
            global::Exa.SearchResultOutputEntitieVariant1PropertiesWebTraffic2? webTraffic,
            global::Exa.SearchResultOutputEntitieVariant1PropertiesResearch2? research)
        {
            this.Name = name;
            this.FoundedYear = foundedYear;
            this.Description = description;
            this.Workforce = workforce;
            this.Headquarters = headquarters;
            this.Financials = financials;
            this.WebTraffic = webTraffic;
            this.Research = research;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1Properties" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1Properties()
        {
        }

    }
}