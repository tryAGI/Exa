
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebsetSearchExcludeItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        Import,
        /// <summary>
        /// 
        /// </summary>
        Webset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsetSearchExcludeItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetSearchExcludeItemSource value)
        {
            return value switch
            {
                WebsetSearchExcludeItemSource.Import => "import",
                WebsetSearchExcludeItemSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetSearchExcludeItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => WebsetSearchExcludeItemSource.Import,
                "webset" => WebsetSearchExcludeItemSource.Webset,
                _ => null,
            };
        }
    }
}