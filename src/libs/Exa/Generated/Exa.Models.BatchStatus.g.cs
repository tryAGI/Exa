
#nullable enable

namespace Exa
{
    /// <summary>
    /// Lifecycle status of the batch.
    /// </summary>
    public enum BatchStatus
    {
        /// <summary>
        ///
        /// </summary>
        Cancelled,
        /// <summary>
        ///
        /// </summary>
        Cancelling,
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchStatus value)
        {
            return value switch
            {
                BatchStatus.Cancelled => "cancelled",
                BatchStatus.Cancelling => "cancelling",
                BatchStatus.Completed => "completed",
                BatchStatus.Expired => "expired",
                BatchStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => BatchStatus.Cancelled,
                "cancelling" => BatchStatus.Cancelling,
                "completed" => BatchStatus.Completed,
                "expired" => BatchStatus.Expired,
                "in_progress" => BatchStatus.InProgress,
                _ => null,
            };
        }
    }
}