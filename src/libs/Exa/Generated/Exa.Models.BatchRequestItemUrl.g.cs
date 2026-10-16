
#nullable enable

namespace Exa
{
    /// <summary>
    /// Target API route for the request.
    /// </summary>
    public enum BatchRequestItemUrl
    {
        /// <summary>
        ///
        /// </summary>
        AgentRuns,
        /// <summary>
        ///
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BatchRequestItemUrlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BatchRequestItemUrl value)
        {
            return value switch
            {
                BatchRequestItemUrl.AgentRuns => "/agent/runs",
                BatchRequestItemUrl.Search => "/search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BatchRequestItemUrl? ToEnum(string value)
        {
            return value switch
            {
                "/agent/runs" => BatchRequestItemUrl.AgentRuns,
                "/search" => BatchRequestItemUrl.Search,
                _ => null,
            };
        }
    }
}