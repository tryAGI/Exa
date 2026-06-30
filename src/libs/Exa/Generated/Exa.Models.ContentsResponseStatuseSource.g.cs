
#nullable enable

namespace Exa
{
    /// <summary>
    /// Where the returned content was sourced from.
    /// </summary>
    public enum ContentsResponseStatuseSource
    {
        /// <summary>
        /// 
        /// </summary>
        Cached,
        /// <summary>
        /// 
        /// </summary>
        Crawled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentsResponseStatuseSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsResponseStatuseSource value)
        {
            return value switch
            {
                ContentsResponseStatuseSource.Cached => "cached",
                ContentsResponseStatuseSource.Crawled => "crawled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsResponseStatuseSource? ToEnum(string value)
        {
            return value switch
            {
                "cached" => ContentsResponseStatuseSource.Cached,
                "crawled" => ContentsResponseStatuseSource.Crawled,
                _ => null,
            };
        }
    }
}