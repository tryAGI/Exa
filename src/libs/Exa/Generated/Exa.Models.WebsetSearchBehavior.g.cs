
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebsetSearchBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Append,
        /// <summary>
        /// 
        /// </summary>
        Override,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsetSearchBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetSearchBehavior value)
        {
            return value switch
            {
                WebsetSearchBehavior.Append => "append",
                WebsetSearchBehavior.Override => "override",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetSearchBehavior? ToEnum(string value)
        {
            return value switch
            {
                "append" => WebsetSearchBehavior.Append,
                "override" => WebsetSearchBehavior.Override,
                _ => null,
            };
        }
    }
}