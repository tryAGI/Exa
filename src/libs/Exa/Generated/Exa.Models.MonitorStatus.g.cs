
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the Monitor
    /// </summary>
    public enum MonitorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonitorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonitorStatus value)
        {
            return value switch
            {
                MonitorStatus.Disabled => "disabled",
                MonitorStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonitorStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => MonitorStatus.Disabled,
                "enabled" => MonitorStatus.Enabled,
                _ => null,
            };
        }
    }
}