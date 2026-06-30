
#nullable enable

namespace Exa
{
    /// <summary>
    /// Controls text rendering verbosity. compact focuses on main content, standard includes more surrounding page context, and full requests the most complete rendered text. Some pages may produce identical standard and full output. Use maxAgeHours: 0 when you need this applied to freshly fetched content.<br/>
    /// Default Value: compact<br/>
    /// Example: standard
    /// </summary>
    public enum ContentsRequestTextVariant1Verbosity2
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
    public static class ContentsRequestTextVariant1Verbosity2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestTextVariant1Verbosity2 value)
        {
            return value switch
            {
                ContentsRequestTextVariant1Verbosity2.Compact => "compact",
                ContentsRequestTextVariant1Verbosity2.Full => "full",
                ContentsRequestTextVariant1Verbosity2.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestTextVariant1Verbosity2? ToEnum(string value)
        {
            return value switch
            {
                "compact" => ContentsRequestTextVariant1Verbosity2.Compact,
                "full" => ContentsRequestTextVariant1Verbosity2.Full,
                "standard" => ContentsRequestTextVariant1Verbosity2.Standard,
                _ => null,
            };
        }
    }
}