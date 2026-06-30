
#nullable enable

namespace Exa
{
    /// <summary>
    /// Controls text rendering verbosity. compact focuses on main content, standard includes more surrounding page context, and full requests the most complete rendered text. Some pages may produce identical standard and full output. Use maxAgeHours: 0 when you need this applied to freshly fetched content.<br/>
    /// Default Value: compact<br/>
    /// Example: standard
    /// </summary>
    public enum SearchMonitorContentsOutputTextVerbosity2
    {
        /// <summary>
        /// 0 when you need this applied to freshly fetched content.
        /// </summary>
        Compact,
        /// <summary>
        /// 0 when you need this applied to freshly fetched content.
        /// </summary>
        Full,
        /// <summary>
        /// 0 when you need this applied to freshly fetched content.
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMonitorContentsOutputTextVerbosity2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsOutputTextVerbosity2 value)
        {
            return value switch
            {
                SearchMonitorContentsOutputTextVerbosity2.Compact => "compact",
                SearchMonitorContentsOutputTextVerbosity2.Full => "full",
                SearchMonitorContentsOutputTextVerbosity2.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsOutputTextVerbosity2? ToEnum(string value)
        {
            return value switch
            {
                "compact" => SearchMonitorContentsOutputTextVerbosity2.Compact,
                "full" => SearchMonitorContentsOutputTextVerbosity2.Full,
                "standard" => SearchMonitorContentsOutputTextVerbosity2.Standard,
                _ => null,
            };
        }
    }
}