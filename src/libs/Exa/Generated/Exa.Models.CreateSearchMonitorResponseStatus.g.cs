
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the monitor. `active` monitors run on schedule and can be triggered manually. `paused` monitors can only be triggered manually. `disabled` monitors are auto-disabled after 10 consecutive authentication failures.
    /// </summary>
    public enum CreateSearchMonitorResponseStatus
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
    public static class CreateSearchMonitorResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchMonitorResponseStatus value)
        {
            return value switch
            {
                CreateSearchMonitorResponseStatus.Active => "active",
                CreateSearchMonitorResponseStatus.Disabled => "disabled",
                CreateSearchMonitorResponseStatus.Paused => "paused",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchMonitorResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => CreateSearchMonitorResponseStatus.Active,
                "disabled" => CreateSearchMonitorResponseStatus.Disabled,
                "paused" => CreateSearchMonitorResponseStatus.Paused,
                _ => null,
            };
        }
    }
}