
#nullable enable

namespace Exa
{
    /// <summary>
    /// Deprecated: Use maxAgeHours instead for content freshness control. livecrawl does not guarantee freshly fetched parser output and may be served according to server freshness policy. Do not send livecrawl and maxAgeHours together.<br/>
    /// Example: preferred
    /// </summary>
    public enum ContentsOptionsLivecrawl2
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
    public static class ContentsOptionsLivecrawl2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsOptionsLivecrawl2 value)
        {
            return value switch
            {
                ContentsOptionsLivecrawl2.Always => "always",
                ContentsOptionsLivecrawl2.Fallback => "fallback",
                ContentsOptionsLivecrawl2.Never => "never",
                ContentsOptionsLivecrawl2.Preferred => "preferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsOptionsLivecrawl2? ToEnum(string value)
        {
            return value switch
            {
                "always" => ContentsOptionsLivecrawl2.Always,
                "fallback" => ContentsOptionsLivecrawl2.Fallback,
                "never" => ContentsOptionsLivecrawl2.Never,
                "preferred" => ContentsOptionsLivecrawl2.Preferred,
                _ => null,
            };
        }
    }
}