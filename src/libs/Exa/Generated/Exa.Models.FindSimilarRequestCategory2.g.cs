
#nullable enable

namespace Exa
{
    /// <summary>
    /// A data category to focus on. Known categories include `company`, `research paper`, `publication`, `news`, `personal site`, `financial report`, and `people`. Other strings are accepted and used as category hints for search. The `people` and `company` categories have improved quality for finding people profiles and company pages. Note: The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.<br/>
    /// Example: research paper
    /// </summary>
    public enum FindSimilarRequestCategory2
    {
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.
        /// </summary>
        Company,
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.
        /// </summary>
        FinancialReport,
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.
        /// </summary>
        News,
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.
        /// </summary>
        People,
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.
        /// </summary>
        PersonalSite,
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.
        /// </summary>
        Publication,
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.
        /// </summary>
        ResearchPaper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FindSimilarRequestCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FindSimilarRequestCategory2 value)
        {
            return value switch
            {
                FindSimilarRequestCategory2.Company => "company",
                FindSimilarRequestCategory2.FinancialReport => "financial report",
                FindSimilarRequestCategory2.News => "news",
                FindSimilarRequestCategory2.People => "people",
                FindSimilarRequestCategory2.PersonalSite => "personal site",
                FindSimilarRequestCategory2.Publication => "publication",
                FindSimilarRequestCategory2.ResearchPaper => "research paper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FindSimilarRequestCategory2? ToEnum(string value)
        {
            return value switch
            {
                "company" => FindSimilarRequestCategory2.Company,
                "financial report" => FindSimilarRequestCategory2.FinancialReport,
                "news" => FindSimilarRequestCategory2.News,
                "people" => FindSimilarRequestCategory2.People,
                "personal site" => FindSimilarRequestCategory2.PersonalSite,
                "publication" => FindSimilarRequestCategory2.Publication,
                "research paper" => FindSimilarRequestCategory2.ResearchPaper,
                _ => null,
            };
        }
    }
}