
#nullable enable

namespace Exa
{
    /// <summary>
    /// Required beta token for the Batch API.
    /// </summary>
    public enum DeleteBatchExaBeta
    {
        /// <summary>
        ///
        /// </summary>
        Batches20260606,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteBatchExaBetaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteBatchExaBeta value)
        {
            return value switch
            {
                DeleteBatchExaBeta.Batches20260606 => "batches-2026-06-06",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteBatchExaBeta? ToEnum(string value)
        {
            return value switch
            {
                "batches-2026-06-06" => DeleteBatchExaBeta.Batches20260606,
                _ => null,
            };
        }
    }
}