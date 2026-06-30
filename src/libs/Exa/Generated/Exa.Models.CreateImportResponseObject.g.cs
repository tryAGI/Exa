
#nullable enable

namespace Exa
{
    /// <summary>
    /// The type of object
    /// </summary>
    public enum CreateImportResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        Import,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImportResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImportResponseObject value)
        {
            return value switch
            {
                CreateImportResponseObject.Import => "import",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImportResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "import" => CreateImportResponseObject.Import,
                _ => null,
            };
        }
    }
}