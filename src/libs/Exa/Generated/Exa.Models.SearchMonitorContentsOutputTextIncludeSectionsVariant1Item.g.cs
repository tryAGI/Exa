
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchMonitorContentsOutputTextIncludeSectionsVariant1Item
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
    public static class SearchMonitorContentsOutputTextIncludeSectionsVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchMonitorContentsOutputTextIncludeSectionsVariant1Item value)
        {
            return value switch
            {
                SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Banner => "banner",
                SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Body => "body",
                SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Footer => "footer",
                SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Header => "header",
                SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Metadata => "metadata",
                SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Navigation => "navigation",
                SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Sidebar => "sidebar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchMonitorContentsOutputTextIncludeSectionsVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "banner" => SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Banner,
                "body" => SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Body,
                "footer" => SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Footer,
                "header" => SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Header,
                "metadata" => SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Metadata,
                "navigation" => SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Navigation,
                "sidebar" => SearchMonitorContentsOutputTextIncludeSectionsVariant1Item.Sidebar,
                _ => null,
            };
        }
    }
}