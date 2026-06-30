
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorContentsLivecrawl
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
    public static class SearchMonitorContentsLivecrawlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsLivecrawl value)
        {
            return value switch
            {
                SearchMonitorContentsLivecrawl.Always => "always",
                SearchMonitorContentsLivecrawl.Fallback => "fallback",
                SearchMonitorContentsLivecrawl.Never => "never",
                SearchMonitorContentsLivecrawl.Preferred => "preferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsLivecrawl? ToEnum(string value)
        {
            return value switch
            {
                "always" => SearchMonitorContentsLivecrawl.Always,
                "fallback" => SearchMonitorContentsLivecrawl.Fallback,
                "never" => SearchMonitorContentsLivecrawl.Never,
                "preferred" => SearchMonitorContentsLivecrawl.Preferred,
                _ => null,
            };
        }
    }
}