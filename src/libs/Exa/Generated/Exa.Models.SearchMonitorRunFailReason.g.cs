
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchMonitorRunFailReason
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
    public static class SearchMonitorRunFailReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorRunFailReason value)
        {
            return value switch
            {
                SearchMonitorRunFailReason.ApiKeyInvalid => "api_key_invalid",
                SearchMonitorRunFailReason.Forbidden => "forbidden",
                SearchMonitorRunFailReason.InsufficientCredits => "insufficient_credits",
                SearchMonitorRunFailReason.InternalError => "internal_error",
                SearchMonitorRunFailReason.InvalidParams => "invalid_params",
                SearchMonitorRunFailReason.RateLimited => "rate_limited",
                SearchMonitorRunFailReason.SearchFailed => "search_failed",
                SearchMonitorRunFailReason.SearchUnavailable => "search_unavailable",
                SearchMonitorRunFailReason.SourceNotAvailable => "source_not_available",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorRunFailReason? ToEnum(string value)
        {
            return value switch
            {
                "api_key_invalid" => SearchMonitorRunFailReason.ApiKeyInvalid,
                "forbidden" => SearchMonitorRunFailReason.Forbidden,
                "insufficient_credits" => SearchMonitorRunFailReason.InsufficientCredits,
                "internal_error" => SearchMonitorRunFailReason.InternalError,
                "invalid_params" => SearchMonitorRunFailReason.InvalidParams,
                "rate_limited" => SearchMonitorRunFailReason.RateLimited,
                "search_failed" => SearchMonitorRunFailReason.SearchFailed,
                "search_unavailable" => SearchMonitorRunFailReason.SearchUnavailable,
                "source_not_available" => SearchMonitorRunFailReason.SourceNotAvailable,
                _ => null,
            };
        }
    }
}