
#nullable enable

namespace Exa
{
    /// <summary>
    /// Preset highlight length: `low`, `medium`, and `high` allocate progressively larger token budgets for the returned highlights. With highlights.dynamic, the preset sets a single shared budget across the whole result set instead of a per-URL budget. Exact budgets are tuned by Exa and may change. Not compatible with maxCharacters or numSentences. Beta: requires the `Exa-Beta: dynamic-highlights-2026-08-28` request header; requests setting `verbosity` without it are rejected.
    /// </summary>
    public enum SearchMonitorContentsOutputHighlightsVerbosity
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
    public static class SearchMonitorContentsOutputHighlightsVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsOutputHighlightsVerbosity value)
        {
            return value switch
            {
                SearchMonitorContentsOutputHighlightsVerbosity.High => "high",
                SearchMonitorContentsOutputHighlightsVerbosity.Low => "low",
                SearchMonitorContentsOutputHighlightsVerbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsOutputHighlightsVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => SearchMonitorContentsOutputHighlightsVerbosity.High,
                "low" => SearchMonitorContentsOutputHighlightsVerbosity.Low,
                "medium" => SearchMonitorContentsOutputHighlightsVerbosity.Medium,
                _ => null,
            };
        }
    }
}