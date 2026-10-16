
#nullable enable

namespace Exa
{
    /// <summary>
    /// Controls text rendering verbosity. compact focuses on main content, standard includes more surrounding page context, and full requests the most complete rendered text. Some pages may produce identical standard and full output.<br/>
    /// Default Value: compact
    /// </summary>
    public enum SearchMonitorContentsTextVerbosity
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
    public static class SearchMonitorContentsTextVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsTextVerbosity value)
        {
            return value switch
            {
                SearchMonitorContentsTextVerbosity.Compact => "compact",
                SearchMonitorContentsTextVerbosity.Full => "full",
                SearchMonitorContentsTextVerbosity.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsTextVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "compact" => SearchMonitorContentsTextVerbosity.Compact,
                "full" => SearchMonitorContentsTextVerbosity.Full,
                "standard" => SearchMonitorContentsTextVerbosity.Standard,
                _ => null,
            };
        }
    }
}