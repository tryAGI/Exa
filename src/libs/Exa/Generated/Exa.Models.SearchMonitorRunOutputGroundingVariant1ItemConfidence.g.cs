
#nullable enable

namespace Exa
{
    /// <summary>
    /// Model-reported reliability for this field.
    /// </summary>
    public enum SearchMonitorRunOutputGroundingVariant1ItemConfidence
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
    public static class SearchMonitorRunOutputGroundingVariant1ItemConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorRunOutputGroundingVariant1ItemConfidence value)
        {
            return value switch
            {
                SearchMonitorRunOutputGroundingVariant1ItemConfidence.High => "high",
                SearchMonitorRunOutputGroundingVariant1ItemConfidence.Low => "low",
                SearchMonitorRunOutputGroundingVariant1ItemConfidence.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorRunOutputGroundingVariant1ItemConfidence? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchMonitorRunOutputGroundingVariant1ItemConfidence.High,
                "low" => SearchMonitorRunOutputGroundingVariant1ItemConfidence.Low,
                "medium" => SearchMonitorRunOutputGroundingVariant1ItemConfidence.Medium,
                _ => null,
            };
        }
    }
}