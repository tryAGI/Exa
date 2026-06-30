
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the enrichment result.
    /// </summary>
    public enum EnrichmentResultStatus
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
    public static class EnrichmentResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnrichmentResultStatus value)
        {
            return value switch
            {
                EnrichmentResultStatus.Canceled => "canceled",
                EnrichmentResultStatus.Completed => "completed",
                EnrichmentResultStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnrichmentResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => EnrichmentResultStatus.Canceled,
                "completed" => EnrichmentResultStatus.Completed,
                "pending" => EnrichmentResultStatus.Pending,
                _ => null,
            };
        }
    }
}