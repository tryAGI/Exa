
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchResponseOutputGroundingItemConfidence
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchResponseOutputGroundingItemConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchResponseOutputGroundingItemConfidence value)
        {
            return value switch
            {
                SearchResponseOutputGroundingItemConfidence.High => "high",
                SearchResponseOutputGroundingItemConfidence.Low => "low",
                SearchResponseOutputGroundingItemConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchResponseOutputGroundingItemConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchResponseOutputGroundingItemConfidence.High,
                "low" => SearchResponseOutputGroundingItemConfidence.Low,
                "medium" => SearchResponseOutputGroundingItemConfidence.Medium,
                _ => null,
            };
        }
    }
}