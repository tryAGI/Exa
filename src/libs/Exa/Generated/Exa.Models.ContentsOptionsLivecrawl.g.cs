
#nullable enable

namespace Exa
{
    /// <summary>
    /// Deprecated. Use `maxAgeHours` instead. Does not guarantee freshly fetched content. Cannot be combined with `maxAgeHours`.
    /// </summary>
    public enum ContentsOptionsLivecrawl
    {
        /// <summary>
        ///
        /// </summary>
        Always,
        /// <summary>
        ///
        /// </summary>
        Fallback,
        /// <summary>
        ///
        /// </summary>
        Never,
        /// <summary>
        ///
        /// </summary>
        Preferred,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentsOptionsLivecrawlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsOptionsLivecrawl value)
        {
            return value switch
            {
                ContentsOptionsLivecrawl.Always => "always",
                ContentsOptionsLivecrawl.Fallback => "fallback",
                ContentsOptionsLivecrawl.Never => "never",
                ContentsOptionsLivecrawl.Preferred => "preferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsOptionsLivecrawl? ToEnum(string value)
        {
            return value switch
            {
                "always" => ContentsOptionsLivecrawl.Always,
                "fallback" => ContentsOptionsLivecrawl.Fallback,
                "never" => ContentsOptionsLivecrawl.Never,
                "preferred" => ContentsOptionsLivecrawl.Preferred,
                _ => null,
            };
        }
    }
}