
#nullable enable

namespace Exa
{
    /// <summary>
    /// Search algorithm used (neural for semantic search, keyword for exact matches)
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Keyword,
        /// <summary>
        /// 
        /// </summary>
        Neural,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOperationDataSearchSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType.Auto => "auto",
                ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType.Fast => "fast",
                ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType.Keyword => "keyword",
                ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType.Neural => "neural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType.Auto,
                "fast" => ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType.Fast,
                "keyword" => ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType.Keyword,
                "neural" => ResearchEventDtoClassVariant2PlanOperationDataSearchSearchType.Neural,
                _ => null,
            };
        }
    }
}