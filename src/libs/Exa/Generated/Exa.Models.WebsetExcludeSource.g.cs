
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebsetExcludeSource
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
    public static class WebsetExcludeSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetExcludeSource value)
        {
            return value switch
            {
                WebsetExcludeSource.Import => "import",
                WebsetExcludeSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetExcludeSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => WebsetExcludeSource.Import,
                "webset" => WebsetExcludeSource.Webset,
                _ => null,
            };
        }
    }
}