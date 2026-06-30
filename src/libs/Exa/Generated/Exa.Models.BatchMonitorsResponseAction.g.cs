
#nullable enable

namespace Exa
{
    /// <summary>
    /// The action that was performed
    /// </summary>
    public enum BatchMonitorsResponseAction
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
    public static class BatchMonitorsResponseActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchMonitorsResponseAction value)
        {
            return value switch
            {
                BatchMonitorsResponseAction.Delete => "delete",
                BatchMonitorsResponseAction.Pause => "pause",
                BatchMonitorsResponseAction.Unpause => "unpause",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchMonitorsResponseAction? ToEnum(string value)
        {
            return value switch
            {
                "delete" => BatchMonitorsResponseAction.Delete,
                "pause" => BatchMonitorsResponseAction.Pause,
                "unpause" => BatchMonitorsResponseAction.Unpause,
                _ => null,
            };
        }
    }
}