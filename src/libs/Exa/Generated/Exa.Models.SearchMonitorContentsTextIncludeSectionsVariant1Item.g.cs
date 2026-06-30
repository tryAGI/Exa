
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorContentsTextIncludeSectionsVariant1Item
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
    public static class SearchMonitorContentsTextIncludeSectionsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsTextIncludeSectionsVariant1Item value)
        {
            return value switch
            {
                SearchMonitorContentsTextIncludeSectionsVariant1Item.Banner => "banner",
                SearchMonitorContentsTextIncludeSectionsVariant1Item.Body => "body",
                SearchMonitorContentsTextIncludeSectionsVariant1Item.Footer => "footer",
                SearchMonitorContentsTextIncludeSectionsVariant1Item.Header => "header",
                SearchMonitorContentsTextIncludeSectionsVariant1Item.Metadata => "metadata",
                SearchMonitorContentsTextIncludeSectionsVariant1Item.Navigation => "navigation",
                SearchMonitorContentsTextIncludeSectionsVariant1Item.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsTextIncludeSectionsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "banner" => SearchMonitorContentsTextIncludeSectionsVariant1Item.Banner,
                "body" => SearchMonitorContentsTextIncludeSectionsVariant1Item.Body,
                "footer" => SearchMonitorContentsTextIncludeSectionsVariant1Item.Footer,
                "header" => SearchMonitorContentsTextIncludeSectionsVariant1Item.Header,
                "metadata" => SearchMonitorContentsTextIncludeSectionsVariant1Item.Metadata,
                "navigation" => SearchMonitorContentsTextIncludeSectionsVariant1Item.Navigation,
                "sidebar" => SearchMonitorContentsTextIncludeSectionsVariant1Item.Sidebar,
                _ => null,
            };
        }
    }
}