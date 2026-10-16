
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public enum GetApiKeyUsageGroupBy
    {
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        Hour,
        /// <summary>
        ///
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetApiKeyUsageGroupByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetApiKeyUsageGroupBy value)
        {
            return value switch
            {
                GetApiKeyUsageGroupBy.Day => "day",
                GetApiKeyUsageGroupBy.Hour => "hour",
                GetApiKeyUsageGroupBy.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetApiKeyUsageGroupBy? ToEnum(string value)
        {
            return value switch
            {
                "day" => GetApiKeyUsageGroupBy.Day,
                "hour" => GetApiKeyUsageGroupBy.Hour,
                "month" => GetApiKeyUsageGroupBy.Month,
                _ => null,
            };
        }
    }
}