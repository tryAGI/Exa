
#nullable enable

namespace Exa
{
    /// <summary>
    /// Search algorithm used (neural for semantic search, keyword for exact matches)
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType
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
    public static class ResearchEventDtoClassVariant3TaskOperationDataSearchSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType.Auto => "auto",
                ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType.Fast => "fast",
                ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType.Keyword => "keyword",
                ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType.Neural => "neural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType.Auto,
                "fast" => ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType.Fast,
                "keyword" => ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType.Keyword,
                "neural" => ResearchEventDtoClassVariant3TaskOperationDataSearchSearchType.Neural,
                _ => null,
            };
        }
    }
}