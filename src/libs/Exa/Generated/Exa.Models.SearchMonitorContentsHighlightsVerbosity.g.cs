
#nullable enable

namespace Exa
{
    /// <summary>
    /// Preset highlight length: `low`, `medium`, and `high` allocate progressively larger token budgets for the returned highlights. With highlights.dynamic, the preset sets a single shared budget across the whole result set instead of a per-URL budget. Exact budgets are tuned by Exa and may change. Not compatible with maxCharacters or numSentences. Beta: requires the `Exa-Beta: dynamic-highlights-2026-08-28` request header; requests setting `verbosity` without it are rejected.
    /// </summary>
    public enum SearchMonitorContentsHighlightsVerbosity
    {
        /// <summary>
        /// `low`, `medium`, and `high` allocate progressively larger token budgets for the returned highlights. With highlights.dynamic, the preset sets a single shared budget across the whole result set instead of a per-URL budget. Exact budgets are tuned by Exa and may change. Not compatible with maxCharacters or numSentences. Beta: requires the `Exa-Beta: dynamic-highlights-2026-08-28` request header; requests setting `verbosity` without it are rejected.
        /// </summary>
        High,
        /// <summary>
        /// `low`, `medium`, and `high` allocate progressively larger token budgets for the returned highlights. With highlights.dynamic, the preset sets a single shared budget across the whole result set instead of a per-URL budget. Exact budgets are tuned by Exa and may change. Not compatible with maxCharacters or numSentences. Beta: requires the `Exa-Beta: dynamic-highlights-2026-08-28` request header; requests setting `verbosity` without it are rejected.
        /// </summary>
        Low,
        /// <summary>
        /// `low`, `medium`, and `high` allocate progressively larger token budgets for the returned highlights. With highlights.dynamic, the preset sets a single shared budget across the whole result set instead of a per-URL budget. Exact budgets are tuned by Exa and may change. Not compatible with maxCharacters or numSentences. Beta: requires the `Exa-Beta: dynamic-highlights-2026-08-28` request header; requests setting `verbosity` without it are rejected.
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchMonitorContentsHighlightsVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsHighlightsVerbosity value)
        {
            return value switch
            {
                SearchMonitorContentsHighlightsVerbosity.High => "high",
                SearchMonitorContentsHighlightsVerbosity.Low => "low",
                SearchMonitorContentsHighlightsVerbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsHighlightsVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchMonitorContentsHighlightsVerbosity.High,
                "low" => SearchMonitorContentsHighlightsVerbosity.Low,
                "medium" => SearchMonitorContentsHighlightsVerbosity.Medium,
                _ => null,
            };
        }
    }
}