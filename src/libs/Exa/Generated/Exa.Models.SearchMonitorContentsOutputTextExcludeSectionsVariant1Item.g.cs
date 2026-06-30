
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorContentsOutputTextExcludeSectionsVariant1Item
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
    public static class SearchMonitorContentsOutputTextExcludeSectionsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsOutputTextExcludeSectionsVariant1Item value)
        {
            return value switch
            {
                SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Banner => "banner",
                SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Body => "body",
                SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Footer => "footer",
                SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Header => "header",
                SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Metadata => "metadata",
                SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Navigation => "navigation",
                SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsOutputTextExcludeSectionsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "banner" => SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Banner,
                "body" => SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Body,
                "footer" => SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Footer,
                "header" => SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Header,
                "metadata" => SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Metadata,
                "navigation" => SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Navigation,
                "sidebar" => SearchMonitorContentsOutputTextExcludeSectionsVariant1Item.Sidebar,
                _ => null,
            };
        }
    }
}