
#nullable enable

namespace Exa
{
    /// <summary>
    /// The reason the import failed
    /// </summary>
    public enum CreateImportResponseFailedReason
    {
        /// <summary>
        /// 
        /// </summary>
        InvalidFileContent,
        /// <summary>
        /// 
        /// </summary>
        InvalidFormat,
        /// <summary>
        /// 
        /// </summary>
        MissingIdentifier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImportResponseFailedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImportResponseFailedReason value)
        {
            return value switch
            {
                CreateImportResponseFailedReason.InvalidFileContent => "invalid_file_content",
                CreateImportResponseFailedReason.InvalidFormat => "invalid_format",
                CreateImportResponseFailedReason.MissingIdentifier => "missing_identifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImportResponseFailedReason? ToEnum(string value)
        {
            return value switch
            {
                "invalid_file_content" => CreateImportResponseFailedReason.InvalidFileContent,
                "invalid_format" => CreateImportResponseFailedReason.InvalidFormat,
                "missing_identifier" => CreateImportResponseFailedReason.MissingIdentifier,
                _ => null,
            };
        }
    }
}