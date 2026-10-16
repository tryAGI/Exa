
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchPersonEntityOutputPropertiesResearchNotableWorkType
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
    public static class SearchPersonEntityOutputPropertiesResearchNotableWorkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchPersonEntityOutputPropertiesResearchNotableWorkType value)
        {
            return value switch
            {
                SearchPersonEntityOutputPropertiesResearchNotableWorkType.Article => "article",
                SearchPersonEntityOutputPropertiesResearchNotableWorkType.Book => "book",
                SearchPersonEntityOutputPropertiesResearchNotableWorkType.BookChapter => "book-chapter",
                SearchPersonEntityOutputPropertiesResearchNotableWorkType.Dataset => "dataset",
                SearchPersonEntityOutputPropertiesResearchNotableWorkType.Dissertation => "dissertation",
                SearchPersonEntityOutputPropertiesResearchNotableWorkType.Preprint => "preprint",
                SearchPersonEntityOutputPropertiesResearchNotableWorkType.Report => "report",
                SearchPersonEntityOutputPropertiesResearchNotableWorkType.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchPersonEntityOutputPropertiesResearchNotableWorkType? ToEnum(string value)
        {
            return value switch
            {
                "article" => SearchPersonEntityOutputPropertiesResearchNotableWorkType.Article,
                "book" => SearchPersonEntityOutputPropertiesResearchNotableWorkType.Book,
                "book-chapter" => SearchPersonEntityOutputPropertiesResearchNotableWorkType.BookChapter,
                "dataset" => SearchPersonEntityOutputPropertiesResearchNotableWorkType.Dataset,
                "dissertation" => SearchPersonEntityOutputPropertiesResearchNotableWorkType.Dissertation,
                "preprint" => SearchPersonEntityOutputPropertiesResearchNotableWorkType.Preprint,
                "report" => SearchPersonEntityOutputPropertiesResearchNotableWorkType.Report,
                "review" => SearchPersonEntityOutputPropertiesResearchNotableWorkType.Review,
                _ => null,
            };
        }
    }
}