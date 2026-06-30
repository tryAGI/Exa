
#nullable enable

namespace Exa
{
    /// <summary>
    /// The source of the Item
    /// </summary>
    public enum WebsetItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        Import,
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsetItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetItemSource value)
        {
            return value switch
            {
                WebsetItemSource.Import => "import",
                WebsetItemSource.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => WebsetItemSource.Import,
                "search" => WebsetItemSource.Search,
                _ => null,
            };
        }
    }
}