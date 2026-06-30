
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationCategory
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
        Github,
        /// <summary>
        /// 
        /// </summary>
        LinkedinProfile,
        /// <summary>
        /// 
        /// </summary>
        Movie,
        /// <summary>
        /// 
        /// </summary>
        News,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
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
        ResearchPaper,
        /// <summary>
        /// 
        /// </summary>
        Song,
        /// <summary>
        /// 
        /// </summary>
        Tweet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationCategory value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationCategory.Company => "company",
                ResearchDtoClassCompletedCitationCategory.FinancialReport => "financial report",
                ResearchDtoClassCompletedCitationCategory.Github => "github",
                ResearchDtoClassCompletedCitationCategory.LinkedinProfile => "linkedin profile",
                ResearchDtoClassCompletedCitationCategory.Movie => "movie",
                ResearchDtoClassCompletedCitationCategory.News => "news",
                ResearchDtoClassCompletedCitationCategory.Pdf => "pdf",
                ResearchDtoClassCompletedCitationCategory.People => "people",
                ResearchDtoClassCompletedCitationCategory.PersonalSite => "personal site",
                ResearchDtoClassCompletedCitationCategory.ResearchPaper => "research paper",
                ResearchDtoClassCompletedCitationCategory.Song => "song",
                ResearchDtoClassCompletedCitationCategory.Tweet => "tweet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationCategory? ToEnum(string value)
        {
            return value switch
            {
                "company" => ResearchDtoClassCompletedCitationCategory.Company,
                "financial report" => ResearchDtoClassCompletedCitationCategory.FinancialReport,
                "github" => ResearchDtoClassCompletedCitationCategory.Github,
                "linkedin profile" => ResearchDtoClassCompletedCitationCategory.LinkedinProfile,
                "movie" => ResearchDtoClassCompletedCitationCategory.Movie,
                "news" => ResearchDtoClassCompletedCitationCategory.News,
                "pdf" => ResearchDtoClassCompletedCitationCategory.Pdf,
                "people" => ResearchDtoClassCompletedCitationCategory.People,
                "personal site" => ResearchDtoClassCompletedCitationCategory.PersonalSite,
                "research paper" => ResearchDtoClassCompletedCitationCategory.ResearchPaper,
                "song" => ResearchDtoClassCompletedCitationCategory.Song,
                "tweet" => ResearchDtoClassCompletedCitationCategory.Tweet,
                _ => null,
            };
        }
    }
}