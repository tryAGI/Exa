
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2
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
    public static class SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2 value)
        {
            return value switch
            {
                SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Article => "article",
                SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Book => "book",
                SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.BookChapter => "book-chapter",
                SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Dataset => "dataset",
                SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Dissertation => "dissertation",
                SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Preprint => "preprint",
                SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Report => "report",
                SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2? ToEnum(string value)
        {
            return value switch
            {
                "article" => SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Article,
                "book" => SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Book,
                "book-chapter" => SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.BookChapter,
                "dataset" => SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Dataset,
                "dissertation" => SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Dissertation,
                "preprint" => SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Preprint,
                "report" => SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Report,
                "review" => SearchResultOutputEntitieVariant2PropertiesResearchNotableWorkType2.Review,
                _ => null,
            };
        }
    }
}