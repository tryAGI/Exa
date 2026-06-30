
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the run
    /// </summary>
    public enum SearchMonitorRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
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
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMonitorRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorRunStatus value)
        {
            return value switch
            {
                SearchMonitorRunStatus.Cancelled => "cancelled",
                SearchMonitorRunStatus.Completed => "completed",
                SearchMonitorRunStatus.Failed => "failed",
                SearchMonitorRunStatus.Pending => "pending",
                SearchMonitorRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => SearchMonitorRunStatus.Cancelled,
                "completed" => SearchMonitorRunStatus.Completed,
                "failed" => SearchMonitorRunStatus.Failed,
                "pending" => SearchMonitorRunStatus.Pending,
                "running" => SearchMonitorRunStatus.Running,
                _ => null,
            };
        }
    }
}