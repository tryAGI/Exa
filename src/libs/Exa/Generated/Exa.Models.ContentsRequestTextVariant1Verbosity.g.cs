
#nullable enable

namespace Exa
{
    /// <summary>
    /// Controls text rendering verbosity. compact focuses on main content, standard includes more surrounding page context, and full requests the most complete rendered text. Some pages may produce identical standard and full output.<br/>
    /// Default Value: compact
    /// </summary>
    public enum ContentsRequestTextVariant1Verbosity
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
    public static class ContentsRequestTextVariant1VerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestTextVariant1Verbosity value)
        {
            return value switch
            {
                ContentsRequestTextVariant1Verbosity.Compact => "compact",
                ContentsRequestTextVariant1Verbosity.Full => "full",
                ContentsRequestTextVariant1Verbosity.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestTextVariant1Verbosity? ToEnum(string value)
        {
            return value switch
            {
                "compact" => ContentsRequestTextVariant1Verbosity.Compact,
                "full" => ContentsRequestTextVariant1Verbosity.Full,
                "standard" => ContentsRequestTextVariant1Verbosity.Standard,
                _ => null,
            };
        }
    }
}