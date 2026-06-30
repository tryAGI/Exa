
#nullable enable

namespace Exa
{
    /// <summary>
    /// The behaviour of the Search when it is added to a Webset.<br/>
    /// Default Value: append
    /// </summary>
    public enum MonitorBehaviorConfigBehavior
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
    public static class MonitorBehaviorConfigBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonitorBehaviorConfigBehavior value)
        {
            return value switch
            {
                MonitorBehaviorConfigBehavior.Append => "append",
                MonitorBehaviorConfigBehavior.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonitorBehaviorConfigBehavior? ToEnum(string value)
        {
            return value switch
            {
                "append" => MonitorBehaviorConfigBehavior.Append,
                "override" => MonitorBehaviorConfigBehavior.Override,
                _ => null,
            };
        }
    }
}