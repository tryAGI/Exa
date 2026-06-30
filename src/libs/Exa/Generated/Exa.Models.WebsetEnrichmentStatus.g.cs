
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the enrichment
    /// </summary>
    public enum WebsetEnrichmentStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsetEnrichmentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetEnrichmentStatus value)
        {
            return value switch
            {
                WebsetEnrichmentStatus.Canceled => "canceled",
                WebsetEnrichmentStatus.Completed => "completed",
                WebsetEnrichmentStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetEnrichmentStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => WebsetEnrichmentStatus.Canceled,
                "completed" => WebsetEnrichmentStatus.Completed,
                "pending" => WebsetEnrichmentStatus.Pending,
                _ => null,
            };
        }
    }
}