
#nullable enable

namespace Exa
{
    /// <summary>
    /// Preset highlight length: `low`, `medium`, and `high` allocate progressively larger token budgets for the returned highlights. With highlights.dynamic, the preset sets a single shared budget across the whole result set instead of a per-URL budget. Exact budgets are tuned by Exa and may change. Not compatible with maxCharacters or numSentences. Beta: requires the `Exa-Beta: dynamic-highlights-2026-08-28` request header; requests setting `verbosity` without it are rejected.
    /// </summary>
    public enum ContentsOptionsHighlightsVariant1Verbosity
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
    public static class ContentsOptionsHighlightsVariant1VerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsOptionsHighlightsVariant1Verbosity value)
        {
            return value switch
            {
                ContentsOptionsHighlightsVariant1Verbosity.High => "high",
                ContentsOptionsHighlightsVariant1Verbosity.Low => "low",
                ContentsOptionsHighlightsVariant1Verbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsOptionsHighlightsVariant1Verbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => ContentsOptionsHighlightsVariant1Verbosity.High,
                "low" => ContentsOptionsHighlightsVariant1Verbosity.Low,
                "medium" => ContentsOptionsHighlightsVariant1Verbosity.Medium,
                _ => null,
            };
        }
    }
}