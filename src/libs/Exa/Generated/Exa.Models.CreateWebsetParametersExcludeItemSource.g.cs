
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebsetParametersExcludeItemSource
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
    public static class CreateWebsetParametersExcludeItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebsetParametersExcludeItemSource value)
        {
            return value switch
            {
                CreateWebsetParametersExcludeItemSource.Import => "import",
                CreateWebsetParametersExcludeItemSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebsetParametersExcludeItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => CreateWebsetParametersExcludeItemSource.Import,
                "webset" => CreateWebsetParametersExcludeItemSource.Webset,
                _ => null,
            };
        }
    }
}