
#nullable enable

namespace Exa
{
    /// <summary>
    /// The status of the Import
    /// </summary>
    public enum CreateImportResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImportResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImportResponseStatus value)
        {
            return value switch
            {
                CreateImportResponseStatus.Canceled => "canceled",
                CreateImportResponseStatus.Completed => "completed",
                CreateImportResponseStatus.Failed => "failed",
                CreateImportResponseStatus.Pending => "pending",
                CreateImportResponseStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImportResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => CreateImportResponseStatus.Canceled,
                "completed" => CreateImportResponseStatus.Completed,
                "failed" => CreateImportResponseStatus.Failed,
                "pending" => CreateImportResponseStatus.Pending,
                "processing" => CreateImportResponseStatus.Processing,
                _ => null,
            };
        }
    }
}