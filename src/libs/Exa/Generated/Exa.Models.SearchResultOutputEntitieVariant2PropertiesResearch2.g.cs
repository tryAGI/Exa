
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant2PropertiesResearch2
    {
        /// <summary>
        /// Lifetime number of works.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("worksCount")]
        public int? WorksCount { get; set; }

        /// <summary>
        /// Lifetime citation count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationCount")]
        public int? CitationCount { get; set; }

        /// <summary>
        /// Research h-index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hIndex")]
        public int? HIndex { get; set; }

        /// <summary>
        /// Year of the first publication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstPublicationYear")]
        public int? FirstPublicationYear { get; set; }

        /// <summary>
        /// Year of the latest publication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latestPublicationYear")]
        public int? LatestPublicationYear { get; set; }

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
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant2PropertiesResearchNotableWork> NotableWorks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant2PropertiesResearch2" /> class.
        /// </summary>
        /// <param name="areas">
        /// Ranked research areas, most active first.
        /// </param>
        /// <param name="notableWorks">
        /// Most-cited notable works.
        /// </param>
        /// <param name="worksCount">
        /// Lifetime number of works.
        /// </param>
        /// <param name="citationCount">
        /// Lifetime citation count.
        /// </param>
        /// <param name="hIndex">
        /// Research h-index.
        /// </param>
        /// <param name="firstPublicationYear">
        /// Year of the first publication.
        /// </param>
        /// <param name="latestPublicationYear">
        /// Year of the latest publication.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant2PropertiesResearch2(
            global::System.Collections.Generic.IList<string> areas,
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant2PropertiesResearchNotableWork> notableWorks,
            int? worksCount,
            int? citationCount,
            int? hIndex,
            int? firstPublicationYear,
            int? latestPublicationYear)
        {
            this.WorksCount = worksCount;
            this.CitationCount = citationCount;
            this.HIndex = hIndex;
            this.FirstPublicationYear = firstPublicationYear;
            this.LatestPublicationYear = latestPublicationYear;
            this.Areas = areas ?? throw new global::System.ArgumentNullException(nameof(areas));
            this.NotableWorks = notableWorks ?? throw new global::System.ArgumentNullException(nameof(notableWorks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant2PropertiesResearch2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant2PropertiesResearch2()
        {
        }

    }
}