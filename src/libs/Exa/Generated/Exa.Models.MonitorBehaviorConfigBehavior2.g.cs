
#nullable enable

namespace Exa
{
    /// <summary>
    /// The behaviour of the Search when it is added to a Webset.<br/>
    /// Default Value: append
    /// </summary>
    public enum MonitorBehaviorConfigBehavior2
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Override,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonitorBehaviorConfigBehavior2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonitorBehaviorConfigBehavior2 value)
        {
            return value switch
            {
                MonitorBehaviorConfigBehavior2.Append => "append",
                MonitorBehaviorConfigBehavior2.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonitorBehaviorConfigBehavior2? ToEnum(string value)
        {
            return value switch
            {
                "append" => MonitorBehaviorConfigBehavior2.Append,
                "override" => MonitorBehaviorConfigBehavior2.Override,
                _ => null,
            };
        }
    }
}