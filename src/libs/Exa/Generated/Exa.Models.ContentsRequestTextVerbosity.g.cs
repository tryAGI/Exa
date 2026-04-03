
#nullable enable

namespace Exa
{
    /// <summary>
    /// Controls the verbosity level of returned content. Requires livecrawl: "always" to take effect.<br/>
    /// - compact: Most concise output, main content only (default)<br/>
    /// - standard: Balanced content with more detail<br/>
    /// - full: Complete content including all sections<br/>
    /// Default Value: compact<br/>
    /// Example: standard
    /// </summary>
    public enum ContentsRequestTextVerbosity
    {
        /// <summary>
        /// Most concise output, main content only (default)
        /// </summary>
        Compact,
        /// <summary>
        /// Complete content including all sections
        /// </summary>
        Full,
        /// <summary>
        /// Balanced content with more detail
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentsRequestTextVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestTextVerbosity value)
        {
            return value switch
            {
                ContentsRequestTextVerbosity.Compact => "compact",
                ContentsRequestTextVerbosity.Full => "full",
                ContentsRequestTextVerbosity.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestTextVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "compact" => ContentsRequestTextVerbosity.Compact,
                "full" => ContentsRequestTextVerbosity.Full,
                "standard" => ContentsRequestTextVerbosity.Standard,
                _ => null,
            };
        }
    }
}