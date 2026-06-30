
#nullable enable

namespace Exa
{
    /// <summary>
    /// Model-reported reliability for this field.
    /// </summary>
    public enum SearchSynthesisOutputOutputGroundingItemConfidence
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
    public static class SearchSynthesisOutputOutputGroundingItemConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchSynthesisOutputOutputGroundingItemConfidence value)
        {
            return value switch
            {
                SearchSynthesisOutputOutputGroundingItemConfidence.High => "high",
                SearchSynthesisOutputOutputGroundingItemConfidence.Low => "low",
                SearchSynthesisOutputOutputGroundingItemConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchSynthesisOutputOutputGroundingItemConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchSynthesisOutputOutputGroundingItemConfidence.High,
                "low" => SearchSynthesisOutputOutputGroundingItemConfidence.Low,
                "medium" => SearchSynthesisOutputOutputGroundingItemConfidence.Medium,
                _ => null,
            };
        }
    }
}