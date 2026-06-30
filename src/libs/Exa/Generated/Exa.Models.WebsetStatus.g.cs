
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the webset
    /// </summary>
    public enum WebsetStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Idle,
        /// <summary>
        /// 
        /// </summary>
        Paused,
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
    public static class WebsetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetStatus value)
        {
            return value switch
            {
                WebsetStatus.Idle => "idle",
                WebsetStatus.Paused => "paused",
                WebsetStatus.Pending => "pending",
                WebsetStatus.Running => "running",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetStatus? ToEnum(string value)
        {
            return value switch
            {
                "idle" => WebsetStatus.Idle,
                "paused" => WebsetStatus.Paused,
                "pending" => WebsetStatus.Pending,
                "running" => WebsetStatus.Running,
                _ => null,
            };
        }
    }
}