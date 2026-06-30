
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Crawl,
        /// <summary>
        /// 
        /// </summary>
        Search,
        /// <summary>
        /// 
        /// </summary>
        Think,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType.Crawl => "crawl",
                ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType.Search => "search",
                ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType.Think => "think",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType.Crawl,
                "search" => ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType.Search,
                "think" => ResearchEventDtoClassVariant2PlanOperationDataDiscriminatorType.Think,
                _ => null,
            };
        }
    }
}