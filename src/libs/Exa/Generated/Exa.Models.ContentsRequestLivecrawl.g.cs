
#nullable enable

namespace Exa
{
    /// <summary>
    /// **Deprecated**: Use `maxAgeHours` instead for more precise control over content freshness.<br/>
    /// Options for livecrawling pages.<br/>
    /// 'never': Disable livecrawling (default for neural search).<br/>
    /// 'fallback': Livecrawl when cache is empty.<br/>
    /// 'preferred': Always try to livecrawl, but fall back to cache if crawling fails.<br/>
    /// 'always': Always live-crawl, never use cache. Only use if you cannot tolerate any cached content. This option is not recommended unless consulted with the Exa team.<br/>
    /// Example: preferred
    /// </summary>
    public enum ContentsRequestLivecrawl
    {
        /// <summary>
        /// Always live-crawl, never use cache. Only use if you cannot tolerate any cached content. This option is not recommended unless consulted with the Exa team.
        /// </summary>
        Always,
        /// <summary>
        /// Livecrawl when cache is empty.
        /// </summary>
        Fallback,
        /// <summary>
        /// Disable livecrawling (default for neural search).
        /// </summary>
        Never,
        /// <summary>
        /// Always try to livecrawl, but fall back to cache if crawling fails.
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