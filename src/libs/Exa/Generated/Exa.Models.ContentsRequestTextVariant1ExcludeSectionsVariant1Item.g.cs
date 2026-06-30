
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContentsRequestTextVariant1ExcludeSectionsVariant1Item
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
    public static class ContentsRequestTextVariant1ExcludeSectionsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentsRequestTextVariant1ExcludeSectionsVariant1Item value)
        {
            return value switch
            {
                ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Banner => "banner",
                ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Body => "body",
                ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Footer => "footer",
                ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Header => "header",
                ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Metadata => "metadata",
                ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Navigation => "navigation",
                ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentsRequestTextVariant1ExcludeSectionsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "banner" => ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Banner,
                "body" => ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Body,
                "footer" => ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Footer,
                "header" => ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Header,
                "metadata" => ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Metadata,
                "navigation" => ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Navigation,
                "sidebar" => ContentsRequestTextVariant1ExcludeSectionsVariant1Item.Sidebar,
                _ => null,
            };
        }
    }
}