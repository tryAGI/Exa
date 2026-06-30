
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebsetParametersImportItemSource
    {
        /// <summary>
        /// 
        /// </summary>
        Import,
        /// <summary>
        /// 
        /// </summary>
        Webset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebsetParametersImportItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebsetParametersImportItemSource value)
        {
            return value switch
            {
                CreateWebsetParametersImportItemSource.Import => "import",
                CreateWebsetParametersImportItemSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebsetParametersImportItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => CreateWebsetParametersImportItemSource.Import,
                "webset" => CreateWebsetParametersImportItemSource.Webset,
                _ => null,
            };
        }
    }
}