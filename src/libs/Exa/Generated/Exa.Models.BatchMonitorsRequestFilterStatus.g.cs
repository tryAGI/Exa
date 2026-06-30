
#nullable enable

namespace Exa
{
    /// <summary>
    /// Filter by monitor status
    /// </summary>
    public enum BatchMonitorsRequestFilterStatus
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
    public static class BatchMonitorsRequestFilterStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchMonitorsRequestFilterStatus value)
        {
            return value switch
            {
                BatchMonitorsRequestFilterStatus.Active => "active",
                BatchMonitorsRequestFilterStatus.Disabled => "disabled",
                BatchMonitorsRequestFilterStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchMonitorsRequestFilterStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BatchMonitorsRequestFilterStatus.Active,
                "disabled" => BatchMonitorsRequestFilterStatus.Disabled,
                "paused" => BatchMonitorsRequestFilterStatus.Paused,
                _ => null,
            };
        }
    }
}