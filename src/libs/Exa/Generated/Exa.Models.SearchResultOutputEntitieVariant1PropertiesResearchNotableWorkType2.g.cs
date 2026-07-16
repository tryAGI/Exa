
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2
    {
        /// <summary>
        /// 
        /// </summary>
        Article,
        /// <summary>
        /// 
        /// </summary>
        Book,
        /// <summary>
        /// 
        /// </summary>
        BookChapter,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        Dissertation,
        /// <summary>
        /// 
        /// </summary>
        Preprint,
        /// <summary>
        /// 
        /// </summary>
        Report,
        /// <summary>
        /// 
        /// </summary>
        Review,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2 value)
        {
            return value switch
            {
                SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Article => "article",
                SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Book => "book",
                SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.BookChapter => "book-chapter",
                SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Dataset => "dataset",
                SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Dissertation => "dissertation",
                SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Preprint => "preprint",
                SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Report => "report",
                SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2? ToEnum(string value)
        {
            return value switch
            {
                "article" => SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Article,
                "book" => SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Book,
                "book-chapter" => SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.BookChapter,
                "dataset" => SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Dataset,
                "dissertation" => SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Dissertation,
                "preprint" => SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Preprint,
                "report" => SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Report,
                "review" => SearchResultOutputEntitieVariant1PropertiesResearchNotableWorkType2.Review,
                _ => null,
            };
        }
    }
}