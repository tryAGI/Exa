
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskOperationDataCrawlType
    {
        /// <summary>
        /// 
        /// </summary>
        Crawl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3TaskOperationDataCrawlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskOperationDataCrawlType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskOperationDataCrawlType.Crawl => "crawl",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskOperationDataCrawlType? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ResearchEventDtoClassVariant3TaskOperationDataCrawlType.Crawl,
                _ => null,
            };
        }
    }
}