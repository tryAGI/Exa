
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImportParametersDiscriminatorFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImportParametersDiscriminatorFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImportParametersDiscriminatorFormat value)
        {
            return value switch
            {
                CreateImportParametersDiscriminatorFormat.Csv => "csv",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImportParametersDiscriminatorFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => CreateImportParametersDiscriminatorFormat.Csv,
                _ => null,
            };
        }
    }
}