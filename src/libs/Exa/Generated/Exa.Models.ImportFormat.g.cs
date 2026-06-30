
#nullable enable

namespace Exa
{
    /// <summary>
    /// The format of the import.
    /// </summary>
    public enum ImportFormat
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
    public static class ImportFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportFormat value)
        {
            return value switch
            {
                ImportFormat.Csv => "csv",
                ImportFormat.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => ImportFormat.Csv,
                "webset" => ImportFormat.Webset,
                _ => null,
            };
        }
    }
}