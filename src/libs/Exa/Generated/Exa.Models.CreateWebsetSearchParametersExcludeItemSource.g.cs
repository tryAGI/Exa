
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebsetSearchParametersExcludeItemSource
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
    public static class CreateWebsetSearchParametersExcludeItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebsetSearchParametersExcludeItemSource value)
        {
            return value switch
            {
                CreateWebsetSearchParametersExcludeItemSource.Import => "import",
                CreateWebsetSearchParametersExcludeItemSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebsetSearchParametersExcludeItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => CreateWebsetSearchParametersExcludeItemSource.Import,
                "webset" => CreateWebsetSearchParametersExcludeItemSource.Webset,
                _ => null,
            };
        }
    }
}