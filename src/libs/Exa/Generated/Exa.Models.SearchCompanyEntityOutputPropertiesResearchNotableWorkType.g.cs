
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchCompanyEntityOutputPropertiesResearchNotableWorkType
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
    public static class SearchCompanyEntityOutputPropertiesResearchNotableWorkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchCompanyEntityOutputPropertiesResearchNotableWorkType value)
        {
            return value switch
            {
                SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Article => "article",
                SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Book => "book",
                SearchCompanyEntityOutputPropertiesResearchNotableWorkType.BookChapter => "book-chapter",
                SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Dataset => "dataset",
                SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Dissertation => "dissertation",
                SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Preprint => "preprint",
                SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Report => "report",
                SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Review => "review",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchCompanyEntityOutputPropertiesResearchNotableWorkType? ToEnum(string value)
        {
            return value switch
            {
                "article" => SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Article,
                "book" => SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Book,
                "book-chapter" => SearchCompanyEntityOutputPropertiesResearchNotableWorkType.BookChapter,
                "dataset" => SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Dataset,
                "dissertation" => SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Dissertation,
                "preprint" => SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Preprint,
                "report" => SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Report,
                "review" => SearchCompanyEntityOutputPropertiesResearchNotableWorkType.Review,
                _ => null,
            };
        }
    }
}