
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebsetSearchScopeItemSource
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
    public static class WebsetSearchScopeItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetSearchScopeItemSource value)
        {
            return value switch
            {
                WebsetSearchScopeItemSource.Import => "import",
                WebsetSearchScopeItemSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetSearchScopeItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => WebsetSearchScopeItemSource.Import,
                "webset" => WebsetSearchScopeItemSource.Webset,
                _ => null,
            };
        }
    }
}