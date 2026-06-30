
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebsetsGetExpandItem
    {
        /// <summary>
        /// 
        /// </summary>
        Items,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsetsGetExpandItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetsGetExpandItem value)
        {
            return value switch
            {
                WebsetsGetExpandItem.Items => "items",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetsGetExpandItem? ToEnum(string value)
        {
            return value switch
            {
                "items" => WebsetsGetExpandItem.Items,
                _ => null,
            };
        }
    }
}