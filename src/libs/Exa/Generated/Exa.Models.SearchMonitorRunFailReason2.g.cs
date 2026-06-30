
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorRunFailReason2
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyInvalid,
        /// <summary>
        /// 
        /// </summary>
        Forbidden,
        /// <summary>
        /// 
        /// </summary>
        InsufficientCredits,
        /// <summary>
        /// 
        /// </summary>
        InternalError,
        /// <summary>
        /// 
        /// </summary>
        InvalidParams,
        /// <summary>
        /// 
        /// </summary>
        RateLimited,
        /// <summary>
        /// 
        /// </summary>
        SearchFailed,
        /// <summary>
        /// 
        /// </summary>
        SearchUnavailable,
        /// <summary>
        /// 
        /// </summary>
        SourceNotAvailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMonitorRunFailReason2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorRunFailReason2 value)
        {
            return value switch
            {
                SearchMonitorRunFailReason2.ApiKeyInvalid => "api_key_invalid",
                SearchMonitorRunFailReason2.Forbidden => "forbidden",
                SearchMonitorRunFailReason2.InsufficientCredits => "insufficient_credits",
                SearchMonitorRunFailReason2.InternalError => "internal_error",
                SearchMonitorRunFailReason2.InvalidParams => "invalid_params",
                SearchMonitorRunFailReason2.RateLimited => "rate_limited",
                SearchMonitorRunFailReason2.SearchFailed => "search_failed",
                SearchMonitorRunFailReason2.SearchUnavailable => "search_unavailable",
                SearchMonitorRunFailReason2.SourceNotAvailable => "source_not_available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorRunFailReason2? ToEnum(string value)
        {
            return value switch
            {
                "api_key_invalid" => SearchMonitorRunFailReason2.ApiKeyInvalid,
                "forbidden" => SearchMonitorRunFailReason2.Forbidden,
                "insufficient_credits" => SearchMonitorRunFailReason2.InsufficientCredits,
                "internal_error" => SearchMonitorRunFailReason2.InternalError,
                "invalid_params" => SearchMonitorRunFailReason2.InvalidParams,
                "rate_limited" => SearchMonitorRunFailReason2.RateLimited,
                "search_failed" => SearchMonitorRunFailReason2.SearchFailed,
                "search_unavailable" => SearchMonitorRunFailReason2.SearchUnavailable,
                "source_not_available" => SearchMonitorRunFailReason2.SourceNotAvailable,
                _ => null,
            };
        }
    }
}