
#nullable enable

namespace Exa
{
    /// <summary>
    /// Publication-specific entity fields.
    /// </summary>
    public sealed partial class SearchPublicationEntityOutputProperties
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
        /// Publication date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public string? Date { get; set; }

        /// <summary>
        /// Publication type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::Exa.SearchPublicationEntityOutputPropertiesType? Type { get; set; }

        /// <summary>
        /// Publication language.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// Number of works citing this publication (incoming references).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationCount")]
        public int? CitationCount { get; set; }

        /// <summary>
        /// Ordered list of authors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchPublicationEntityOutputPropertiesAuthor> Authors { get; set; }

        /// <summary>
        /// Number of works this publication cites (outgoing references).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceCount")]
        public int? ReferenceCount { get; set; }

        /// <summary>
        /// Publication abstract text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abstract")]
        public string? Abstract { get; set; }

        /// <summary>
        /// Bare DOI identifier (e.g. 10.1234/abcd).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doi")]
        public string? Doi { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPublicationEntityOutputProperties" /> class.
        /// </summary>
        /// <param name="authors">
        /// Ordered list of authors.
        /// </param>
        /// <param name="title">
        /// Publication title.
        /// </param>
        /// <param name="year">
        /// Publication year.
        /// </param>
        /// <param name="date">
        /// Publication date.
        /// </param>
        /// <param name="type">
        /// Publication type.
        /// </param>
        /// <param name="language">
        /// Publication language.
        /// </param>
        /// <param name="citationCount">
        /// Number of works citing this publication (incoming references).
        /// </param>
        /// <param name="referenceCount">
        /// Number of works this publication cites (outgoing references).
        /// </param>
        /// <param name="abstract">
        /// Publication abstract text.
        /// </param>
        /// <param name="doi">
        /// Bare DOI identifier (e.g. 10.1234/abcd).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPublicationEntityOutputProperties(
            global::System.Collections.Generic.IList<global::Exa.SearchPublicationEntityOutputPropertiesAuthor> authors,
            string? title,
            int? year,
            string? date,
            global::Exa.SearchPublicationEntityOutputPropertiesType? type,
            string? language,
            int? citationCount,
            int? referenceCount,
            string? @abstract,
            string? doi)
        {
            this.Title = title;
            this.Year = year;
            this.Date = date;
            this.Type = type;
            this.Language = language;
            this.CitationCount = citationCount;
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
            this.ReferenceCount = referenceCount;
            this.Abstract = @abstract;
            this.Doi = doi;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPublicationEntityOutputProperties" /> class.
        /// </summary>
        public SearchPublicationEntityOutputProperties()
        {
        }

    }
}