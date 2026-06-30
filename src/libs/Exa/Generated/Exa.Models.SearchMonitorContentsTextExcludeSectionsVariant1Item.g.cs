
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorContentsTextExcludeSectionsVariant1Item
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
    public static class SearchMonitorContentsTextExcludeSectionsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsTextExcludeSectionsVariant1Item value)
        {
            return value switch
            {
                SearchMonitorContentsTextExcludeSectionsVariant1Item.Banner => "banner",
                SearchMonitorContentsTextExcludeSectionsVariant1Item.Body => "body",
                SearchMonitorContentsTextExcludeSectionsVariant1Item.Footer => "footer",
                SearchMonitorContentsTextExcludeSectionsVariant1Item.Header => "header",
                SearchMonitorContentsTextExcludeSectionsVariant1Item.Metadata => "metadata",
                SearchMonitorContentsTextExcludeSectionsVariant1Item.Navigation => "navigation",
                SearchMonitorContentsTextExcludeSectionsVariant1Item.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsTextExcludeSectionsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "banner" => SearchMonitorContentsTextExcludeSectionsVariant1Item.Banner,
                "body" => SearchMonitorContentsTextExcludeSectionsVariant1Item.Body,
                "footer" => SearchMonitorContentsTextExcludeSectionsVariant1Item.Footer,
                "header" => SearchMonitorContentsTextExcludeSectionsVariant1Item.Header,
                "metadata" => SearchMonitorContentsTextExcludeSectionsVariant1Item.Metadata,
                "navigation" => SearchMonitorContentsTextExcludeSectionsVariant1Item.Navigation,
                "sidebar" => SearchMonitorContentsTextExcludeSectionsVariant1Item.Sidebar,
                _ => null,
            };
        }
    }
}