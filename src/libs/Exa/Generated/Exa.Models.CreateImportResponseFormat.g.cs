
#nullable enable

namespace Exa
{
    /// <summary>
    /// The format of the import.
    /// </summary>
    public enum CreateImportResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Webset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImportResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImportResponseFormat value)
        {
            return value switch
            {
                CreateImportResponseFormat.Csv => "csv",
                CreateImportResponseFormat.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImportResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => CreateImportResponseFormat.Csv,
                "webset" => CreateImportResponseFormat.Webset,
                _ => null,
            };
        }
    }
}