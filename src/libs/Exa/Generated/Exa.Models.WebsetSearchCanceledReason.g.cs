
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebsetSearchCanceledReason
    {
        /// <summary>
        /// 
        /// </summary>
        OutOfCredits,
        /// <summary>
        /// 
        /// </summary>
        WebsetCanceled,
        /// <summary>
        /// 
        /// </summary>
        WebsetDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebsetSearchCanceledReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebsetSearchCanceledReason value)
        {
            return value switch
            {
                WebsetSearchCanceledReason.OutOfCredits => "out_of_credits",
                WebsetSearchCanceledReason.WebsetCanceled => "webset_canceled",
                WebsetSearchCanceledReason.WebsetDeleted => "webset_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebsetSearchCanceledReason? ToEnum(string value)
        {
            return value switch
            {
                "out_of_credits" => WebsetSearchCanceledReason.OutOfCredits,
                "webset_canceled" => WebsetSearchCanceledReason.WebsetCanceled,
                "webset_deleted" => WebsetSearchCanceledReason.WebsetDeleted,
                _ => null,
            };
        }
    }
}