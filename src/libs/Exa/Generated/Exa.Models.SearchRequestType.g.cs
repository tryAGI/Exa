
#nullable enable

namespace Exa
{
    /// <summary>
    /// The type of search. Neural uses an embeddings-based model, auto (default) intelligently combines neural and other search methods, fast uses streamlined versions of the search models, deep is light deep search, deep-reasoning is base deep search, and instant provides the lowest latency search optimized for real-time applications.<br/>
    /// Default Value: auto<br/>
    /// Example: auto
    /// </summary>
    public enum SearchRequestType
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
        DeepReasoning,
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Instant,
        /// <summary>
        /// 
        /// </summary>
        Neural,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestType value)
        {
            return value switch
            {
                SearchRequestType.Auto => "auto",
                SearchRequestType.Deep => "deep",
                SearchRequestType.DeepReasoning => "deep-reasoning",
                SearchRequestType.Fast => "fast",
                SearchRequestType.Instant => "instant",
                SearchRequestType.Neural => "neural",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestType? ToEnum(string value)
        {
            return value switch
            {
                "auto" => SearchRequestType.Auto,
                "deep" => SearchRequestType.Deep,
                "deep-reasoning" => SearchRequestType.DeepReasoning,
                "fast" => SearchRequestType.Fast,
                "instant" => SearchRequestType.Instant,
                "neural" => SearchRequestType.Neural,
                _ => null,
            };
        }
    }
}