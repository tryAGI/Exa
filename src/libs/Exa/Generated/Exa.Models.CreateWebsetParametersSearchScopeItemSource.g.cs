
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebsetParametersSearchScopeItemSource
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
    public static class CreateWebsetParametersSearchScopeItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebsetParametersSearchScopeItemSource value)
        {
            return value switch
            {
                CreateWebsetParametersSearchScopeItemSource.Import => "import",
                CreateWebsetParametersSearchScopeItemSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebsetParametersSearchScopeItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => CreateWebsetParametersSearchScopeItemSource.Import,
                "webset" => CreateWebsetParametersSearchScopeItemSource.Webset,
                _ => null,
            };
        }
    }
}