
#nullable enable

namespace Exa
{
    /// <summary>
    /// Model-reported reliability for this field.
    /// </summary>
    public enum SearchStreamGroundingChunkOutputGroundingItemConfidence
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
    public static class SearchStreamGroundingChunkOutputGroundingItemConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchStreamGroundingChunkOutputGroundingItemConfidence value)
        {
            return value switch
            {
                SearchStreamGroundingChunkOutputGroundingItemConfidence.High => "high",
                SearchStreamGroundingChunkOutputGroundingItemConfidence.Low => "low",
                SearchStreamGroundingChunkOutputGroundingItemConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchStreamGroundingChunkOutputGroundingItemConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchStreamGroundingChunkOutputGroundingItemConfidence.High,
                "low" => SearchStreamGroundingChunkOutputGroundingItemConfidence.Low,
                "medium" => SearchStreamGroundingChunkOutputGroundingItemConfidence.Medium,
                _ => null,
            };
        }
    }
}