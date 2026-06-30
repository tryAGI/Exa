
#nullable enable

namespace Exa
{
    /// <summary>
    /// The reason the import failed
    /// </summary>
    public enum ImportFailedReason
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
    public static class ImportFailedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportFailedReason value)
        {
            return value switch
            {
                ImportFailedReason.InvalidFileContent => "invalid_file_content",
                ImportFailedReason.InvalidFormat => "invalid_format",
                ImportFailedReason.MissingIdentifier => "missing_identifier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportFailedReason? ToEnum(string value)
        {
            return value switch
            {
                "invalid_file_content" => ImportFailedReason.InvalidFileContent,
                "invalid_format" => ImportFailedReason.InvalidFormat,
                "missing_identifier" => ImportFailedReason.MissingIdentifier,
                _ => null,
            };
        }
    }
}