
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchPublicationEntityOutputPropertiesType
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
    public static class SearchPublicationEntityOutputPropertiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPublicationEntityOutputPropertiesType value)
        {
            return value switch
            {
                SearchPublicationEntityOutputPropertiesType.Article => "article",
                SearchPublicationEntityOutputPropertiesType.Book => "book",
                SearchPublicationEntityOutputPropertiesType.BookChapter => "book-chapter",
                SearchPublicationEntityOutputPropertiesType.Dataset => "dataset",
                SearchPublicationEntityOutputPropertiesType.Dissertation => "dissertation",
                SearchPublicationEntityOutputPropertiesType.Preprint => "preprint",
                SearchPublicationEntityOutputPropertiesType.Report => "report",
                SearchPublicationEntityOutputPropertiesType.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPublicationEntityOutputPropertiesType? ToEnum(string value)
        {
            return value switch
            {
                "article" => SearchPublicationEntityOutputPropertiesType.Article,
                "book" => SearchPublicationEntityOutputPropertiesType.Book,
                "book-chapter" => SearchPublicationEntityOutputPropertiesType.BookChapter,
                "dataset" => SearchPublicationEntityOutputPropertiesType.Dataset,
                "dissertation" => SearchPublicationEntityOutputPropertiesType.Dissertation,
                "preprint" => SearchPublicationEntityOutputPropertiesType.Preprint,
                "report" => SearchPublicationEntityOutputPropertiesType.Report,
                "review" => SearchPublicationEntityOutputPropertiesType.Review,
                _ => null,
            };
        }
    }
}