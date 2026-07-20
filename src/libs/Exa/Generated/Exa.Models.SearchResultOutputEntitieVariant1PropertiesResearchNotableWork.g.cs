
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesResearchNotableWork
    {
        /// <summary>
        /// Publication title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Publication year.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("year")]
        public int? Year { get; set; }

        /// <summary>
        /// Publication venue.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("venue")]
        public string? Venue { get; set; }

        /// <summary>
        /// Number of works citing this publication.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationCount")]
        public int? CitationCount { get; set; }

        /// <summary>
        /// Digital Object Identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doi")]
        public string? Doi { get; set; }

        /// <summary>
        /// Resolved publication entity identifier, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Publication type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Exa.SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesResearchNotableWork" /> class.
        /// </summary>
        /// <param name="title">
        /// Publication title.
        /// </param>
        /// <param name="year">
        /// Publication year.
        /// </param>
        /// <param name="venue">
        /// Publication venue.
        /// </param>
        /// <param name="citationCount">
        /// Number of works citing this publication.
        /// </param>
        /// <param name="doi">
        /// Digital Object Identifier.
        /// </param>
        /// <param name="id">
        /// Resolved publication entity identifier, when available.
        /// </param>
        /// <param name="type">
        /// Publication type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesResearchNotableWork(
            string? title,
            int? year,
            string? venue,
            int? citationCount,
            string? doi,
            string? id,
            global::Exa.SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2? type)
        {
            this.Title = title;
            this.Year = year;
            this.Venue = venue;
            this.CitationCount = citationCount;
            this.Doi = doi;
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesResearchNotableWork" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesResearchNotableWork()
        {
        }

    }
}