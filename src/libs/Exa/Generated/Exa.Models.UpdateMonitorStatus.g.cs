
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the monitor.
    /// </summary>
    public enum UpdateMonitorStatus
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
    public static class UpdateMonitorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateMonitorStatus value)
        {
            return value switch
            {
                UpdateMonitorStatus.Disabled => "disabled",
                UpdateMonitorStatus.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateMonitorStatus? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => UpdateMonitorStatus.Disabled,
                "enabled" => UpdateMonitorStatus.Enabled,
                _ => null,
            };
        }
    }
}