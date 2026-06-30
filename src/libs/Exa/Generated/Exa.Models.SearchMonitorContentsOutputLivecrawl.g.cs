
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorContentsOutputLivecrawl
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
    public static class SearchMonitorContentsOutputLivecrawlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsOutputLivecrawl value)
        {
            return value switch
            {
                SearchMonitorContentsOutputLivecrawl.Always => "always",
                SearchMonitorContentsOutputLivecrawl.Fallback => "fallback",
                SearchMonitorContentsOutputLivecrawl.Never => "never",
                SearchMonitorContentsOutputLivecrawl.Preferred => "preferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsOutputLivecrawl? ToEnum(string value)
        {
            return value switch
            {
                "always" => SearchMonitorContentsOutputLivecrawl.Always,
                "fallback" => SearchMonitorContentsOutputLivecrawl.Fallback,
                "never" => SearchMonitorContentsOutputLivecrawl.Never,
                "preferred" => SearchMonitorContentsOutputLivecrawl.Preferred,
                _ => null,
            };
        }
    }
}