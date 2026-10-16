
#nullable enable

namespace Exa
{
    /// <summary>
    /// Deprecated. Use `maxAgeHours` instead. Does not guarantee freshly fetched content. Cannot be combined with `maxAgeHours`.
    /// </summary>
    public enum ContentsRequestLivecrawl
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
    public static class ContentsRequestLivecrawlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestLivecrawl value)
        {
            return value switch
            {
                ContentsRequestLivecrawl.Always => "always",
                ContentsRequestLivecrawl.Fallback => "fallback",
                ContentsRequestLivecrawl.Never => "never",
                ContentsRequestLivecrawl.Preferred => "preferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestLivecrawl? ToEnum(string value)
        {
            return value switch
            {
                "always" => ContentsRequestLivecrawl.Always,
                "fallback" => ContentsRequestLivecrawl.Fallback,
                "never" => ContentsRequestLivecrawl.Never,
                "preferred" => ContentsRequestLivecrawl.Preferred,
                _ => null,
            };
        }
    }
}