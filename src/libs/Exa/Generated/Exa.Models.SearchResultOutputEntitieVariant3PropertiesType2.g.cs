
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchResultOutputEntitieVariant3PropertiesType2
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
    public static class SearchResultOutputEntitieVariant3PropertiesType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResultOutputEntitieVariant3PropertiesType2 value)
        {
            return value switch
            {
                SearchResultOutputEntitieVariant3PropertiesType2.Article => "article",
                SearchResultOutputEntitieVariant3PropertiesType2.Book => "book",
                SearchResultOutputEntitieVariant3PropertiesType2.BookChapter => "book-chapter",
                SearchResultOutputEntitieVariant3PropertiesType2.Dataset => "dataset",
                SearchResultOutputEntitieVariant3PropertiesType2.Dissertation => "dissertation",
                SearchResultOutputEntitieVariant3PropertiesType2.Preprint => "preprint",
                SearchResultOutputEntitieVariant3PropertiesType2.Report => "report",
                SearchResultOutputEntitieVariant3PropertiesType2.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResultOutputEntitieVariant3PropertiesType2? ToEnum(string value)
        {
            return value switch
            {
                "article" => SearchResultOutputEntitieVariant3PropertiesType2.Article,
                "book" => SearchResultOutputEntitieVariant3PropertiesType2.Book,
                "book-chapter" => SearchResultOutputEntitieVariant3PropertiesType2.BookChapter,
                "dataset" => SearchResultOutputEntitieVariant3PropertiesType2.Dataset,
                "dissertation" => SearchResultOutputEntitieVariant3PropertiesType2.Dissertation,
                "preprint" => SearchResultOutputEntitieVariant3PropertiesType2.Preprint,
                "report" => SearchResultOutputEntitieVariant3PropertiesType2.Report,
                "review" => SearchResultOutputEntitieVariant3PropertiesType2.Review,
                _ => null,
            };
        }
    }
}