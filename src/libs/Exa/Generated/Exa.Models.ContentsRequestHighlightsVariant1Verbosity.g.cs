
#nullable enable

namespace Exa
{
    /// <summary>
    /// Preset highlight length: `low`, `medium`, and `high` allocate progressively larger token budgets for the returned highlights. With highlights.dynamic, the preset sets a single shared budget across the whole result set instead of a per-URL budget. Exact budgets are tuned by Exa and may change. Not compatible with maxCharacters or numSentences. Beta: requires the `Exa-Beta: dynamic-highlights-2026-08-28` request header; requests setting `verbosity` without it are rejected.
    /// </summary>
    public enum ContentsRequestHighlightsVariant1Verbosity
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
    public static class ContentsRequestHighlightsVariant1VerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestHighlightsVariant1Verbosity value)
        {
            return value switch
            {
                ContentsRequestHighlightsVariant1Verbosity.High => "high",
                ContentsRequestHighlightsVariant1Verbosity.Low => "low",
                ContentsRequestHighlightsVariant1Verbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestHighlightsVariant1Verbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => ContentsRequestHighlightsVariant1Verbosity.High,
                "low" => ContentsRequestHighlightsVariant1Verbosity.Low,
                "medium" => ContentsRequestHighlightsVariant1Verbosity.Medium,
                _ => null,
            };
        }
    }
}