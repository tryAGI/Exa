
#nullable enable

namespace Exa
{
    /// <summary>
    /// A data category to focus on. The `people` and `company` categories have improved quality for finding LinkedIn profiles and company pages. Note: The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `includeText`, `excludeText`, `excludeDomains`. For `people` category, `includeDomains` only accepts LinkedIn domains. Using unsupported parameters will result in a 400 error.<br/>
    /// Example: research paper
    /// </summary>
    public enum SearchRequestCategory
    {
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `includeText`, `excludeText`, `excludeDomains`. For `people` category, `includeDomains` only accepts LinkedIn domains. Using unsupported parameters will result in a 400 error.
        /// </summary>
        Company,
        /// <summary>
        /// 
        /// </summary>
        FinancialReport,
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        News,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// The `company` and `people` categories only support a limited set of filters. The following parameters are NOT supported for these categories: `startPublishedDate`, `endPublishedDate`, `startCrawlDate`, `endCrawlDate`, `includeText`, `excludeText`, `excludeDomains`. For `people` category, `includeDomains` only accepts LinkedIn domains. Using unsupported parameters will result in a 400 error.
        /// </summary>
        People,
        /// <summary>
        /// 
        /// </summary>
        PersonalSite,
        /// <summary>
        /// 
        /// </summary>
        ResearchPaper,
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
                SearchRequestCategory.Github => "github",
                SearchRequestCategory.News => "news",
                SearchRequestCategory.Pdf => "pdf",
                SearchRequestCategory.People => "people",
                SearchRequestCategory.PersonalSite => "personal site",
                SearchRequestCategory.ResearchPaper => "research paper",
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
                "github" => SearchRequestCategory.Github,
                "news" => SearchRequestCategory.News,
                "pdf" => SearchRequestCategory.Pdf,
                "people" => SearchRequestCategory.People,
                "personal site" => SearchRequestCategory.PersonalSite,
                "research paper" => SearchRequestCategory.ResearchPaper,
                _ => null,
            };
        }
    }
}