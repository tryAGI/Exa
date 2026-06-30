
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchEventDtoClassVariant3TaskOperationDataSearchType
    {
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchEventDtoClassVariant3TaskOperationDataSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchEventDtoClassVariant3TaskOperationDataSearchType value)
        {
            return value switch
            {
                ResearchEventDtoClassVariant3TaskOperationDataSearchType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchEventDtoClassVariant3TaskOperationDataSearchType? ToEnum(string value)
        {
            return value switch
            {
                "search" => ResearchEventDtoClassVariant3TaskOperationDataSearchType.Search,
                _ => null,
            };
        }
    }
}