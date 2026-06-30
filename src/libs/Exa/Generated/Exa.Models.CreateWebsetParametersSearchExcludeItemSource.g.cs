
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateWebsetParametersSearchExcludeItemSource
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
    public static class CreateWebsetParametersSearchExcludeItemSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebsetParametersSearchExcludeItemSource value)
        {
            return value switch
            {
                CreateWebsetParametersSearchExcludeItemSource.Import => "import",
                CreateWebsetParametersSearchExcludeItemSource.Webset => "webset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebsetParametersSearchExcludeItemSource? ToEnum(string value)
        {
            return value switch
            {
                "import" => CreateWebsetParametersSearchExcludeItemSource.Import,
                "webset" => CreateWebsetParametersSearchExcludeItemSource.Webset,
                _ => null,
            };
        }
    }
}