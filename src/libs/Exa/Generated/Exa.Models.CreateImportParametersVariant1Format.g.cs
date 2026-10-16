
#nullable enable

namespace Exa
{
    /// <summary>
    /// The file format. The CSV must include a column that identifies each entity, or the import fails.
    /// </summary>
    public enum CreateImportParametersVariant1Format
    {
        /// <summary>
        ///
        /// </summary>
        Csv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImportParametersVariant1FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImportParametersVariant1Format value)
        {
            return value switch
            {
                CreateImportParametersVariant1Format.Csv => "csv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImportParametersVariant1Format? ToEnum(string value)
        {
            return value switch
            {
                "csv" => CreateImportParametersVariant1Format.Csv,
                _ => null,
            };
        }
    }
}