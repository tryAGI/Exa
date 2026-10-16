
#nullable enable

namespace Exa
{
    /// <summary>
    /// Required beta token for the Batch API.
    /// </summary>
    public enum CancelBatchExaBeta
    {
        /// <summary>
        ///
        /// </summary>
        Batches20260606,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelBatchExaBetaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelBatchExaBeta value)
        {
            return value switch
            {
                CancelBatchExaBeta.Batches20260606 => "batches-2026-06-06",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelBatchExaBeta? ToEnum(string value)
        {
            return value switch
            {
                "batches-2026-06-06" => CancelBatchExaBeta.Batches20260606,
                _ => null,
            };
        }
    }
}