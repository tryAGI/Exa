
#nullable enable

namespace Exa
{
    /// <summary>
    /// Deprecated: Use maxAgeHours instead for content freshness control. livecrawl does not guarantee freshly fetched parser output and may be served according to server freshness policy. Do not send livecrawl and maxAgeHours together.<br/>
    /// Example: preferred
    /// </summary>
    public enum ContentsRequestLivecrawl2
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
    public static class ContentsRequestLivecrawl2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestLivecrawl2 value)
        {
            return value switch
            {
                ContentsRequestLivecrawl2.Always => "always",
                ContentsRequestLivecrawl2.Fallback => "fallback",
                ContentsRequestLivecrawl2.Never => "never",
                ContentsRequestLivecrawl2.Preferred => "preferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestLivecrawl2? ToEnum(string value)
        {
            return value switch
            {
                "always" => ContentsRequestLivecrawl2.Always,
                "fallback" => ContentsRequestLivecrawl2.Fallback,
                "never" => ContentsRequestLivecrawl2.Never,
                "preferred" => ContentsRequestLivecrawl2.Preferred,
                _ => null,
            };
        }
    }
}