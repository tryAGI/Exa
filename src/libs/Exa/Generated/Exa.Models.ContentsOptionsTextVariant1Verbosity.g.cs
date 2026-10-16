
#nullable enable

namespace Exa
{
    /// <summary>
    /// Controls text rendering verbosity. compact focuses on main content, standard includes more surrounding page context, and full requests the most complete rendered text. Some pages may produce identical standard and full output.<br/>
    /// Default Value: compact
    /// </summary>
    public enum ContentsOptionsTextVariant1Verbosity
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
    public static class ContentsOptionsTextVariant1VerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsOptionsTextVariant1Verbosity value)
        {
            return value switch
            {
                ContentsOptionsTextVariant1Verbosity.Compact => "compact",
                ContentsOptionsTextVariant1Verbosity.Full => "full",
                ContentsOptionsTextVariant1Verbosity.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsOptionsTextVariant1Verbosity? ToEnum(string value)
        {
            return value switch
            {
                "compact" => ContentsOptionsTextVariant1Verbosity.Compact,
                "full" => ContentsOptionsTextVariant1Verbosity.Full,
                "standard" => ContentsOptionsTextVariant1Verbosity.Standard,
                _ => null,
            };
        }
    }
}