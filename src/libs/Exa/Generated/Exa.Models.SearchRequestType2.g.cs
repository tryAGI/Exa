
#nullable enable

namespace Exa
{
    /// <summary>
    /// The search mode to use. `auto` (default) is a balanced mode that optimizes for both quality and speed and is recommended for most applications. `fast` returns high-quality results with reduced latency, making it a good fit for user-facing search and interactive workflows. `instant` is optimized for minimum response time, trading some search depth for speed in real-time experiences such as chat, voice agents, and autocomplete. `deep-lite` performs lightweight research with synthesized results and a consistent 4-second latency, lower than full deep search. `deep` conducts comprehensive multi-step research with synthesis, while `deep-reasoning` adds stronger reasoning for complex analysis and decision-making tasks.<br/>
    /// Default Value: auto<br/>
    /// Example: auto
    /// </summary>
    public enum SearchRequestType2
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Deep,
        /// <summary>
        /// 
        /// </summary>
        DeepLite,
        /// <summary>
        /// 
        /// </summary>
        DeepReasoning,
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Instant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestType2 value)
        {
            return value switch
            {
                SearchRequestType2.Auto => "auto",
                SearchRequestType2.Deep => "deep",
                SearchRequestType2.DeepLite => "deep-lite",
                SearchRequestType2.DeepReasoning => "deep-reasoning",
                SearchRequestType2.Fast => "fast",
                SearchRequestType2.Instant => "instant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestType2? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SearchRequestType2.Auto,
                "deep" => SearchRequestType2.Deep,
                "deep-lite" => SearchRequestType2.DeepLite,
                "deep-reasoning" => SearchRequestType2.DeepReasoning,
                "fast" => SearchRequestType2.Fast,
                "instant" => SearchRequestType2.Instant,
                _ => null,
            };
        }
    }
}