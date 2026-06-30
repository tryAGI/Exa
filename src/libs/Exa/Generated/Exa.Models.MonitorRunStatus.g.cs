
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the Monitor Run
    /// </summary>
    public enum MonitorRunStatus
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
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Running,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonitorRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonitorRunStatus value)
        {
            return value switch
            {
                MonitorRunStatus.Canceled => "canceled",
                MonitorRunStatus.Completed => "completed",
                MonitorRunStatus.Created => "created",
                MonitorRunStatus.Failed => "failed",
                MonitorRunStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonitorRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => MonitorRunStatus.Canceled,
                "completed" => MonitorRunStatus.Completed,
                "created" => MonitorRunStatus.Created,
                "failed" => MonitorRunStatus.Failed,
                "running" => MonitorRunStatus.Running,
                _ => null,
            };
        }
    }
}