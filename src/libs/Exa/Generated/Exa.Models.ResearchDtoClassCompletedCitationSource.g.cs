
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCompletedCitationSource
    {
        /// <summary>
        /// 
        /// </summary>
        Contents,
        /// <summary>
        /// 
        /// </summary>
        Coresignal,
        /// <summary>
        /// 
        /// </summary>
        KeywordKnowledgeGraph,
        /// <summary>
        /// 
        /// </summary>
        KeywordOrganic,
        /// <summary>
        /// 
        /// </summary>
        KeywordOrganicSerp,
        /// <summary>
        /// 
        /// </summary>
        Neural,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Zilliz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCompletedCitationSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCompletedCitationSource value)
        {
            return value switch
            {
                ResearchDtoClassCompletedCitationSource.Contents => "contents",
                ResearchDtoClassCompletedCitationSource.Coresignal => "coresignal",
                ResearchDtoClassCompletedCitationSource.KeywordKnowledgeGraph => "keyword-knowledge-graph",
                ResearchDtoClassCompletedCitationSource.KeywordOrganic => "keyword-organic",
                ResearchDtoClassCompletedCitationSource.KeywordOrganicSerp => "keyword-organic-serp",
                ResearchDtoClassCompletedCitationSource.Neural => "neural",
                ResearchDtoClassCompletedCitationSource.User => "user",
                ResearchDtoClassCompletedCitationSource.Zilliz => "zilliz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCompletedCitationSource? ToEnum(string value)
        {
            return value switch
            {
                "contents" => ResearchDtoClassCompletedCitationSource.Contents,
                "coresignal" => ResearchDtoClassCompletedCitationSource.Coresignal,
                "keyword-knowledge-graph" => ResearchDtoClassCompletedCitationSource.KeywordKnowledgeGraph,
                "keyword-organic" => ResearchDtoClassCompletedCitationSource.KeywordOrganic,
                "keyword-organic-serp" => ResearchDtoClassCompletedCitationSource.KeywordOrganicSerp,
                "neural" => ResearchDtoClassCompletedCitationSource.Neural,
                "user" => ResearchDtoClassCompletedCitationSource.User,
                "zilliz" => ResearchDtoClassCompletedCitationSource.Zilliz,
                _ => null,
            };
        }
    }
}