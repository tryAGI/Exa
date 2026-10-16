
#nullable enable

namespace Exa
{
    /// <summary>
    /// A data category to focus on. Other strings are accepted and used as category hints. `people` and `company` return higher-quality people profiles and company pages. `publication` returns scholarly publications such as research papers, preprints, and journal articles, with metadata like authors, venue, and citations. With `company` or `people`, domain, URL, published-date, and text filters are ignored.
    /// </summary>
    public enum FindSimilarRequestCategory
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
    public static class FindSimilarRequestCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindSimilarRequestCategory value)
        {
            return value switch
            {
                FindSimilarRequestCategory.Company => "company",
                FindSimilarRequestCategory.FinancialReport => "financial report",
                FindSimilarRequestCategory.News => "news",
                FindSimilarRequestCategory.People => "people",
                FindSimilarRequestCategory.PersonalSite => "personal site",
                FindSimilarRequestCategory.Publication => "publication",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindSimilarRequestCategory? ToEnum(string value)
        {
            return value switch
            {
                "company" => FindSimilarRequestCategory.Company,
                "financial report" => FindSimilarRequestCategory.FinancialReport,
                "news" => FindSimilarRequestCategory.News,
                "people" => FindSimilarRequestCategory.People,
                "personal site" => FindSimilarRequestCategory.PersonalSite,
                "publication" => FindSimilarRequestCategory.Publication,
                _ => null,
            };
        }
    }
}