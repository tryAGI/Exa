
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesResearch2
    {
        /// <summary>
        /// Number of works with an affiliated author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worksCount")]
        public int? WorksCount { get; set; }

        /// <summary>
        /// Lifetime citation count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationCount")]
        public int? CitationCount { get; set; }

        /// <summary>
        /// Ranked research areas, most active first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("areas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Areas { get; set; }

        /// <summary>
        /// Most-cited notable works.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notableWorks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant1PropertiesResearchNotableWork> NotableWorks { get; set; }

        /// <summary>
        /// Researchers ordered by works produced at the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topResearchers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant1PropertiesResearchTopResearcher> TopResearchers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesResearch2" /> class.
        /// </summary>
        /// <param name="areas">
        /// Ranked research areas, most active first.
        /// </param>
        /// <param name="notableWorks">
        /// Most-cited notable works.
        /// </param>
        /// <param name="topResearchers">
        /// Researchers ordered by works produced at the organization.
        /// </param>
        /// <param name="worksCount">
        /// Number of works with an affiliated author.
        /// </param>
        /// <param name="citationCount">
        /// Lifetime citation count.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesResearch2(
            global::System.Collections.Generic.IList<string> areas,
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant1PropertiesResearchNotableWork> notableWorks,
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant1PropertiesResearchTopResearcher> topResearchers,
            int? worksCount,
            int? citationCount)
        {
            this.WorksCount = worksCount;
            this.CitationCount = citationCount;
            this.Areas = areas ?? throw new global::System.ArgumentNullException(nameof(areas));
            this.NotableWorks = notableWorks ?? throw new global::System.ArgumentNullException(nameof(notableWorks));
            this.TopResearchers = topResearchers ?? throw new global::System.ArgumentNullException(nameof(topResearchers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesResearch2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesResearch2()
        {
        }

    }
}