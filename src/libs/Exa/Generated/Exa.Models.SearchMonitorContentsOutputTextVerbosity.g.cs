
#nullable enable

namespace Exa
{
    /// <summary>
    /// Controls text rendering verbosity. compact focuses on main content, standard includes more surrounding page context, and full requests the most complete rendered text. Some pages may produce identical standard and full output.<br/>
    /// Default Value: compact
    /// </summary>
    public enum SearchMonitorContentsOutputTextVerbosity
    {
        /// <summary>
        ///
        /// </summary>
        Compact,
        /// <summary>
        ///
        /// </summary>
        Full,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMonitorContentsOutputTextVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsOutputTextVerbosity value)
        {
            return value switch
            {
                SearchMonitorContentsOutputTextVerbosity.Compact => "compact",
                SearchMonitorContentsOutputTextVerbosity.Full => "full",
                SearchMonitorContentsOutputTextVerbosity.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsOutputTextVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "compact" => SearchMonitorContentsOutputTextVerbosity.Compact,
                "full" => SearchMonitorContentsOutputTextVerbosity.Full,
                "standard" => SearchMonitorContentsOutputTextVerbosity.Standard,
                _ => null,
            };
        }
    }
}