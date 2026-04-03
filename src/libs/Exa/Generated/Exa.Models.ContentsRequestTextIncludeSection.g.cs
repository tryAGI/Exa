
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentsRequestTextIncludeSection
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
    public static class ContentsRequestTextIncludeSectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestTextIncludeSection value)
        {
            return value switch
            {
                ContentsRequestTextIncludeSection.Banner => "banner",
                ContentsRequestTextIncludeSection.Body => "body",
                ContentsRequestTextIncludeSection.Footer => "footer",
                ContentsRequestTextIncludeSection.Header => "header",
                ContentsRequestTextIncludeSection.Metadata => "metadata",
                ContentsRequestTextIncludeSection.Navigation => "navigation",
                ContentsRequestTextIncludeSection.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestTextIncludeSection? ToEnum(string value)
        {
            return value switch
            {
                "banner" => ContentsRequestTextIncludeSection.Banner,
                "body" => ContentsRequestTextIncludeSection.Body,
                "footer" => ContentsRequestTextIncludeSection.Footer,
                "header" => ContentsRequestTextIncludeSection.Header,
                "metadata" => ContentsRequestTextIncludeSection.Metadata,
                "navigation" => ContentsRequestTextIncludeSection.Navigation,
                "sidebar" => ContentsRequestTextIncludeSection.Sidebar,
                _ => null,
            };
        }
    }
}