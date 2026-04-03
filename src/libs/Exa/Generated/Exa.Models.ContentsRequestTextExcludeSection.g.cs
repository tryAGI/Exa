
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentsRequestTextExcludeSection
    {
        /// <summary>
        /// 
        /// </summary>
        Banner,
        /// <summary>
        /// 
        /// </summary>
        Body,
        /// <summary>
        /// 
        /// </summary>
        Footer,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Navigation,
        /// <summary>
        /// 
        /// </summary>
        Sidebar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentsRequestTextExcludeSectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestTextExcludeSection value)
        {
            return value switch
            {
                ContentsRequestTextExcludeSection.Banner => "banner",
                ContentsRequestTextExcludeSection.Body => "body",
                ContentsRequestTextExcludeSection.Footer => "footer",
                ContentsRequestTextExcludeSection.Header => "header",
                ContentsRequestTextExcludeSection.Metadata => "metadata",
                ContentsRequestTextExcludeSection.Navigation => "navigation",
                ContentsRequestTextExcludeSection.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestTextExcludeSection? ToEnum(string value)
        {
            return value switch
            {
                "banner" => ContentsRequestTextExcludeSection.Banner,
                "body" => ContentsRequestTextExcludeSection.Body,
                "footer" => ContentsRequestTextExcludeSection.Footer,
                "header" => ContentsRequestTextExcludeSection.Header,
                "metadata" => ContentsRequestTextExcludeSection.Metadata,
                "navigation" => ContentsRequestTextExcludeSection.Navigation,
                "sidebar" => ContentsRequestTextExcludeSection.Sidebar,
                _ => null,
            };
        }
    }
}