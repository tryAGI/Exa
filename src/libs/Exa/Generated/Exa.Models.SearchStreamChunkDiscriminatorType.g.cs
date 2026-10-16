
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchStreamChunkDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Done,
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Grounding,
        /// <summary>
        ///
        /// </summary>
        Results,
        /// <summary>
        ///
        /// </summary>
        StreamReset,
        /// <summary>
        ///
        /// </summary>
        TextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchStreamChunkDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchStreamChunkDiscriminatorType value)
        {
            return value switch
            {
                SearchStreamChunkDiscriminatorType.Done => "done",
                SearchStreamChunkDiscriminatorType.Error => "error",
                SearchStreamChunkDiscriminatorType.Grounding => "grounding",
                SearchStreamChunkDiscriminatorType.Results => "results",
                SearchStreamChunkDiscriminatorType.StreamReset => "stream-reset",
                SearchStreamChunkDiscriminatorType.TextDelta => "text-delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchStreamChunkDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "done" => SearchStreamChunkDiscriminatorType.Done,
                "error" => SearchStreamChunkDiscriminatorType.Error,
                "grounding" => SearchStreamChunkDiscriminatorType.Grounding,
                "results" => SearchStreamChunkDiscriminatorType.Results,
                "stream-reset" => SearchStreamChunkDiscriminatorType.StreamReset,
                "text-delta" => SearchStreamChunkDiscriminatorType.TextDelta,
                _ => null,
            };
        }
    }
}