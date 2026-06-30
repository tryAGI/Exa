
#nullable enable

namespace Exa
{
    /// <summary>
    /// The type of object
    /// </summary>
    public enum ImportObject
    {
        /// <summary>
        /// 
        /// </summary>
        Import,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImportObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImportObject value)
        {
            return value switch
            {
                ImportObject.Import => "import",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImportObject? ToEnum(string value)
        {
            return value switch
            {
                "import" => ImportObject.Import,
                _ => null,
            };
        }
    }
}