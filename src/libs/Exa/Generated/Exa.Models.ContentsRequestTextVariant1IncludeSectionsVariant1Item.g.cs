
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentsRequestTextVariant1IncludeSectionsVariant1Item
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
    public static class ContentsRequestTextVariant1IncludeSectionsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestTextVariant1IncludeSectionsVariant1Item value)
        {
            return value switch
            {
                ContentsRequestTextVariant1IncludeSectionsVariant1Item.Banner => "banner",
                ContentsRequestTextVariant1IncludeSectionsVariant1Item.Body => "body",
                ContentsRequestTextVariant1IncludeSectionsVariant1Item.Footer => "footer",
                ContentsRequestTextVariant1IncludeSectionsVariant1Item.Header => "header",
                ContentsRequestTextVariant1IncludeSectionsVariant1Item.Metadata => "metadata",
                ContentsRequestTextVariant1IncludeSectionsVariant1Item.Navigation => "navigation",
                ContentsRequestTextVariant1IncludeSectionsVariant1Item.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestTextVariant1IncludeSectionsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "banner" => ContentsRequestTextVariant1IncludeSectionsVariant1Item.Banner,
                "body" => ContentsRequestTextVariant1IncludeSectionsVariant1Item.Body,
                "footer" => ContentsRequestTextVariant1IncludeSectionsVariant1Item.Footer,
                "header" => ContentsRequestTextVariant1IncludeSectionsVariant1Item.Header,
                "metadata" => ContentsRequestTextVariant1IncludeSectionsVariant1Item.Metadata,
                "navigation" => ContentsRequestTextVariant1IncludeSectionsVariant1Item.Navigation,
                "sidebar" => ContentsRequestTextVariant1IncludeSectionsVariant1Item.Sidebar,
                _ => null,
            };
        }
    }
}