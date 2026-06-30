
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the monitor. `active` monitors run on schedule and can be triggered manually. `paused` monitors can only be triggered manually. `disabled` monitors are auto-disabled after 10 consecutive authentication failures.
    /// </summary>
    public enum SearchMonitorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMonitorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorStatus value)
        {
            return value switch
            {
                SearchMonitorStatus.Active => "active",
                SearchMonitorStatus.Disabled => "disabled",
                SearchMonitorStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => SearchMonitorStatus.Active,
                "disabled" => SearchMonitorStatus.Disabled,
                "paused" => SearchMonitorStatus.Paused,
                _ => null,
            };
        }
    }
}