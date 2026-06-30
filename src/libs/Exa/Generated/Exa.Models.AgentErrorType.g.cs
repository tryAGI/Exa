
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthenticationError,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        RateLimitError,
        /// <summary>
        /// 
        /// </summary>
        ServerError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentErrorType value)
        {
            return value switch
            {
                AgentErrorType.AuthenticationError => "AUTHENTICATION_ERROR",
                AgentErrorType.InvalidRequest => "INVALID_REQUEST",
                AgentErrorType.NotFound => "NOT_FOUND",
                AgentErrorType.RateLimitError => "RATE_LIMIT_ERROR",
                AgentErrorType.ServerError => "SERVER_ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentErrorType? ToEnum(string value)
        {
            return value switch
            {
                "AUTHENTICATION_ERROR" => AgentErrorType.AuthenticationError,
                "INVALID_REQUEST" => AgentErrorType.InvalidRequest,
                "NOT_FOUND" => AgentErrorType.NotFound,
                "RATE_LIMIT_ERROR" => AgentErrorType.RateLimitError,
                "SERVER_ERROR" => AgentErrorType.ServerError,
                _ => null,
            };
        }
    }
}