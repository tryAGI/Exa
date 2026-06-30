
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResearchDtoClassCanceledStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResearchDtoClassCanceledStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResearchDtoClassCanceledStatus value)
        {
            return value switch
            {
                ResearchDtoClassCanceledStatus.Canceled => "canceled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResearchDtoClassCanceledStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => ResearchDtoClassCanceledStatus.Canceled,
                _ => null,
            };
        }
    }
}