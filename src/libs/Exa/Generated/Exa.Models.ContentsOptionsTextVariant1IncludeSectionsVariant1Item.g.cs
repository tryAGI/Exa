
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentsOptionsTextVariant1IncludeSectionsVariant1Item
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
    public static class ContentsOptionsTextVariant1IncludeSectionsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsOptionsTextVariant1IncludeSectionsVariant1Item value)
        {
            return value switch
            {
                ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Banner => "banner",
                ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Body => "body",
                ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Footer => "footer",
                ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Header => "header",
                ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Metadata => "metadata",
                ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Navigation => "navigation",
                ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsOptionsTextVariant1IncludeSectionsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "banner" => ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Banner,
                "body" => ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Body,
                "footer" => ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Footer,
                "header" => ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Header,
                "metadata" => ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Metadata,
                "navigation" => ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Navigation,
                "sidebar" => ContentsOptionsTextVariant1IncludeSectionsVariant1Item.Sidebar,
                _ => null,
            };
        }
    }
}