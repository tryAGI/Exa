
#nullable enable

namespace Exa
{
    /// <summary>
    /// A data category to focus on. Other strings are accepted and used as category hints. `people` and `company` return higher-quality people profiles and company pages. `publication` returns scholarly publications such as research papers, preprints, and journal articles, with metadata like authors, venue, and citations. `company` and `people` do not support `startPublishedDate` or `endPublishedDate`, and `people` also does not support `excludeDomains`. Requests that set an unsupported filter return a 400 error.
    /// </summary>
    public enum SearchRequestCategory
    {
        /// <summary>
        ///
        /// </summary>
        Company,
        /// <summary>
        ///
        /// </summary>
        FinancialReport,
        /// <summary>
        ///
        /// </summary>
        News,
        /// <summary>
        ///
        /// </summary>
        People,
        /// <summary>
        ///
        /// </summary>
        PersonalSite,
        /// <summary>
        ///
        /// </summary>
        Publication,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestCategory value)
        {
            return value switch
            {
                SearchRequestCategory.Company => "company",
                SearchRequestCategory.FinancialReport => "financial report",
                SearchRequestCategory.News => "news",
                SearchRequestCategory.People => "people",
                SearchRequestCategory.PersonalSite => "personal site",
                SearchRequestCategory.Publication => "publication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestCategory? ToEnum(string value)
        {
            return value switch
            {
                "company" => SearchRequestCategory.Company,
                "financial report" => SearchRequestCategory.FinancialReport,
                "news" => SearchRequestCategory.News,
                "people" => SearchRequestCategory.People,
                "personal site" => SearchRequestCategory.PersonalSite,
                "publication" => SearchRequestCategory.Publication,
                _ => null,
            };
        }
    }
}