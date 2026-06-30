
#nullable enable

namespace Exa
{
    /// <summary>
    /// The action to perform on matching monitors. `delete` permanently removes them, `pause` sets their status to paused, and `unpause` sets their status to active.
    /// </summary>
    public enum BatchMonitorsRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Pause,
        /// <summary>
        /// 
        /// </summary>
        Unpause,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchMonitorsRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchMonitorsRequestAction value)
        {
            return value switch
            {
                BatchMonitorsRequestAction.Delete => "delete",
                BatchMonitorsRequestAction.Pause => "pause",
                BatchMonitorsRequestAction.Unpause => "unpause",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchMonitorsRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "delete" => BatchMonitorsRequestAction.Delete,
                "pause" => BatchMonitorsRequestAction.Pause,
                "unpause" => BatchMonitorsRequestAction.Unpause,
                _ => null,
            };
        }
    }
}