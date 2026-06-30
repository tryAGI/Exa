
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOperationDataCrawlType
    {
        /// <summary>
        /// 
        /// </summary>
        Crawl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOperationDataCrawlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOperationDataCrawlType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOperationDataCrawlType.Crawl => "crawl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOperationDataCrawlType? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ResearchEventDtoClassVariant2PlanOperationDataCrawlType.Crawl,
                _ => null,
            };
        }
    }
}