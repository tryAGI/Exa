
#nullable enable

namespace Exa
{
    /// <summary>
    /// The type of object
    /// </summary>
    public enum MonitorRunObject
    {
        /// <summary>
        /// 
        /// </summary>
        MonitorRun,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonitorRunObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonitorRunObject value)
        {
            return value switch
            {
                MonitorRunObject.MonitorRun => "monitor_run",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonitorRunObject? ToEnum(string value)
        {
            return value switch
            {
                "monitor_run" => MonitorRunObject.MonitorRun,
                _ => null,
            };
        }
    }
}