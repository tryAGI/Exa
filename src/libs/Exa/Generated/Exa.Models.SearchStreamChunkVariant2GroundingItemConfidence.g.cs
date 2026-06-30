
#nullable enable

namespace Exa
{
    /// <summary>
    /// Model-reported reliability for this field.
    /// </summary>
    public enum SearchStreamChunkVariant2GroundingItemConfidence
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
    public static class SearchStreamChunkVariant2GroundingItemConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchStreamChunkVariant2GroundingItemConfidence value)
        {
            return value switch
            {
                SearchStreamChunkVariant2GroundingItemConfidence.High => "high",
                SearchStreamChunkVariant2GroundingItemConfidence.Low => "low",
                SearchStreamChunkVariant2GroundingItemConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchStreamChunkVariant2GroundingItemConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchStreamChunkVariant2GroundingItemConfidence.High,
                "low" => SearchStreamChunkVariant2GroundingItemConfidence.Low,
                "medium" => SearchStreamChunkVariant2GroundingItemConfidence.Medium,
                _ => null,
            };
        }
    }
}