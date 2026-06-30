
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType
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
    public static class ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Crawl => "crawl",
                ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Search => "search",
                ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Think => "think",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Crawl,
                "search" => ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Search,
                "think" => ResearchEventDtoClassVariant3TaskOperationDataDiscriminatorType.Think,
                _ => null,
            };
        }
    }
}