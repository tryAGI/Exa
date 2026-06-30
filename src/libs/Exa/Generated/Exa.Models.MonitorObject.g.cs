
#nullable enable

namespace Exa
{
    /// <summary>
    /// The type of object
    /// </summary>
    public enum MonitorObject
    {
        /// <summary>
        /// 
        /// </summary>
        Monitor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonitorObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonitorObject value)
        {
            return value switch
            {
                MonitorObject.Monitor => "monitor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonitorObject? ToEnum(string value)
        {
            return value switch
            {
                "monitor" => MonitorObject.Monitor,
                _ => null,
            };
        }
    }
}