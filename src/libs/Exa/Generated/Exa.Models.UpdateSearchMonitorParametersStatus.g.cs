
#nullable enable

namespace Exa
{
    /// <summary>
    /// Update the monitor status (can only set to `active` or `paused`)
    /// </summary>
    public enum UpdateSearchMonitorParametersStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Paused,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSearchMonitorParametersStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSearchMonitorParametersStatus value)
        {
            return value switch
            {
                UpdateSearchMonitorParametersStatus.Active => "active",
                UpdateSearchMonitorParametersStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSearchMonitorParametersStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => UpdateSearchMonitorParametersStatus.Active,
                "paused" => UpdateSearchMonitorParametersStatus.Paused,
                _ => null,
            };
        }
    }
}