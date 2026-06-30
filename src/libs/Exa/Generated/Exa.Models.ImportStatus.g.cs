
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the Import
    /// </summary>
    public enum ImportStatus
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
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportStatus value)
        {
            return value switch
            {
                ImportStatus.Canceled => "canceled",
                ImportStatus.Completed => "completed",
                ImportStatus.Failed => "failed",
                ImportStatus.Pending => "pending",
                ImportStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ImportStatus.Canceled,
                "completed" => ImportStatus.Completed,
                "failed" => ImportStatus.Failed,
                "pending" => ImportStatus.Pending,
                "processing" => ImportStatus.Processing,
                _ => null,
            };
        }
    }
}