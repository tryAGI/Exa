
#nullable enable

namespace Exa
{
    /// <summary>
    /// Status of the content fetch operation.<br/>
    /// Example: success
    /// </summary>
    public enum ContentsResponseStatuseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentsResponseStatuseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsResponseStatuseStatus value)
        {
            return value switch
            {
                ContentsResponseStatuseStatus.Error => "error",
                ContentsResponseStatuseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsResponseStatuseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => ContentsResponseStatuseStatus.Error,
                "success" => ContentsResponseStatuseStatus.Success,
                _ => null,
            };
        }
    }
}