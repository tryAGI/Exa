
#nullable enable

namespace Exa
{
    /// <summary>
    /// Filter monitors by status
    /// </summary>
    public enum ListMonitorsStatus
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
    public static class ListMonitorsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMonitorsStatus value)
        {
            return value switch
            {
                ListMonitorsStatus.Active => "active",
                ListMonitorsStatus.Disabled => "disabled",
                ListMonitorsStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMonitorsStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListMonitorsStatus.Active,
                "disabled" => ListMonitorsStatus.Disabled,
                "paused" => ListMonitorsStatus.Paused,
                _ => null,
            };
        }
    }
}