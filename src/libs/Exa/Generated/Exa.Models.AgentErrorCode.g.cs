
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        ConcurrencyLimitReached,
        /// <summary>
        /// 
        /// </summary>
        InvalidDataSource,
        /// <summary>
        /// 
        /// </summary>
        InvalidOutputSchema,
        /// <summary>
        /// 
        /// </summary>
        InvalidRequest,
        /// <summary>
        /// 
        /// </summary>
        PreviousRunNotCompleted,
        /// <summary>
        /// 
        /// </summary>
        PreviousRunNotFound,
        /// <summary>
        /// 
        /// </summary>
        RunNotFound,
        /// <summary>
        /// 
        /// </summary>
        ServerError,
        /// <summary>
        /// 
        /// </summary>
        TeamNotFound,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentErrorCode value)
        {
            return value switch
            {
                AgentErrorCode.ConcurrencyLimitReached => "CONCURRENCY_LIMIT_REACHED",
                AgentErrorCode.InvalidDataSource => "INVALID_DATA_SOURCE",
                AgentErrorCode.InvalidOutputSchema => "INVALID_OUTPUT_SCHEMA",
                AgentErrorCode.InvalidRequest => "INVALID_REQUEST",
                AgentErrorCode.PreviousRunNotCompleted => "PREVIOUS_RUN_NOT_COMPLETED",
                AgentErrorCode.PreviousRunNotFound => "PREVIOUS_RUN_NOT_FOUND",
                AgentErrorCode.RunNotFound => "RUN_NOT_FOUND",
                AgentErrorCode.ServerError => "SERVER_ERROR",
                AgentErrorCode.TeamNotFound => "TEAM_NOT_FOUND",
                AgentErrorCode.Timeout => "TIMEOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "CONCURRENCY_LIMIT_REACHED" => AgentErrorCode.ConcurrencyLimitReached,
                "INVALID_DATA_SOURCE" => AgentErrorCode.InvalidDataSource,
                "INVALID_OUTPUT_SCHEMA" => AgentErrorCode.InvalidOutputSchema,
                "INVALID_REQUEST" => AgentErrorCode.InvalidRequest,
                "PREVIOUS_RUN_NOT_COMPLETED" => AgentErrorCode.PreviousRunNotCompleted,
                "PREVIOUS_RUN_NOT_FOUND" => AgentErrorCode.PreviousRunNotFound,
                "RUN_NOT_FOUND" => AgentErrorCode.RunNotFound,
                "SERVER_ERROR" => AgentErrorCode.ServerError,
                "TEAM_NOT_FOUND" => AgentErrorCode.TeamNotFound,
                "TIMEOUT" => AgentErrorCode.Timeout,
                _ => null,
            };
        }
    }
}