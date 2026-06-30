
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentsOptionsTextVariant1ExcludeSectionsVariant1Item
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
    public static class ContentsOptionsTextVariant1ExcludeSectionsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsOptionsTextVariant1ExcludeSectionsVariant1Item value)
        {
            return value switch
            {
                ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Banner => "banner",
                ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Body => "body",
                ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Footer => "footer",
                ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Header => "header",
                ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Metadata => "metadata",
                ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Navigation => "navigation",
                ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsOptionsTextVariant1ExcludeSectionsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "banner" => ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Banner,
                "body" => ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Body,
                "footer" => ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Footer,
                "header" => ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Header,
                "metadata" => ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Metadata,
                "navigation" => ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Navigation,
                "sidebar" => ContentsOptionsTextVariant1ExcludeSectionsVariant1Item.Sidebar,
                _ => null,
            };
        }
    }
}