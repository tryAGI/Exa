
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesResearchTopResearcher
    {
        /// <summary>
        /// Referenced researcher.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person")]
        public global::Exa.SearchResultOutputEntitieVariant1PropertiesResearchTopResearcherPerson2? Person { get; set; }

        /// <summary>
        /// Number of works produced at the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worksCount")]
        public int? WorksCount { get; set; }

        /// <summary>
        /// Number of citations for works produced at the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationCount")]
        public int? CitationCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesResearchTopResearcher" /> class.
        /// </summary>
        /// <param name="person">
        /// Referenced researcher.
        /// </param>
        /// <param name="worksCount">
        /// Number of works produced at the organization.
        /// </param>
        /// <param name="citationCount">
        /// Number of citations for works produced at the organization.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesResearchTopResearcher(
            global::Exa.SearchResultOutputEntitieVariant1PropertiesResearchTopResearcherPerson2? person,
            int? worksCount,
            int? citationCount)
        {
            this.Person = person;
            this.WorksCount = worksCount;
            this.CitationCount = citationCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesResearchTopResearcher" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesResearchTopResearcher()
        {
        }

    }
}