
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebsetSearchParametersScopeItemSource
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
    public static class CreateWebsetSearchParametersScopeItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebsetSearchParametersScopeItemSource value)
        {
            return value switch
            {
                CreateWebsetSearchParametersScopeItemSource.Import => "import",
                CreateWebsetSearchParametersScopeItemSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebsetSearchParametersScopeItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => CreateWebsetSearchParametersScopeItemSource.Import,
                "webset" => CreateWebsetSearchParametersScopeItemSource.Webset,
                _ => null,
            };
        }
    }
}