
#nullable enable

namespace Exa
{
    /// <summary>
    /// A data category to focus on. Known categories include `company`, `research paper`, `news`, `personal site`, `financial report`, and `people`. Other strings are accepted and used as category hints for search. The `people` and `company` categories have improved quality for finding people profiles and company pages. Note: The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `excludeDomains`. Using unsupported parameters will result in a 400 error.<br/>
    /// Example: research paper
    /// </summary>
    public enum SearchRequestCategory2
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
        ResearchPaper,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestCategory2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestCategory2 value)
        {
            return value switch
            {
                SearchRequestCategory2.Company => "company",
                SearchRequestCategory2.FinancialReport => "financial report",
                SearchRequestCategory2.News => "news",
                SearchRequestCategory2.People => "people",
                SearchRequestCategory2.PersonalSite => "personal site",
                SearchRequestCategory2.ResearchPaper => "research paper",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestCategory2? ToEnum(string value)
        {
            return value switch
            {
                "company" => SearchRequestCategory2.Company,
                "financial report" => SearchRequestCategory2.FinancialReport,
                "news" => SearchRequestCategory2.News,
                "people" => SearchRequestCategory2.People,
                "personal site" => SearchRequestCategory2.PersonalSite,
                "research paper" => SearchRequestCategory2.ResearchPaper,
                _ => null,
            };
        }
    }
}