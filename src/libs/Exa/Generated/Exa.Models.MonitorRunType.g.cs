
#nullable enable

namespace Exa
{
    /// <summary>
    /// The type of the Monitor Run
    /// </summary>
    public enum MonitorRunType
    {
        /// <summary>
        /// 
        /// </summary>
        Refresh,
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonitorRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonitorRunType value)
        {
            return value switch
            {
                MonitorRunType.Refresh => "refresh",
                MonitorRunType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonitorRunType? ToEnum(string value)
        {
            return value switch
            {
                "refresh" => MonitorRunType.Refresh,
                "search" => MonitorRunType.Search,
                _ => null,
            };
        }
    }
}