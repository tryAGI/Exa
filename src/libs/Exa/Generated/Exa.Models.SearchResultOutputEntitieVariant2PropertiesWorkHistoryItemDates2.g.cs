
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemDates2
    {
        /// <summary>
        /// Start date for the date range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        public string? From { get; set; }

        /// <summary>
        /// End date for the date range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        public string? To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemDates2" /> class.
        /// </summary>
        /// <param name="from">
        /// Start date for the date range.
        /// </param>
        /// <param name="to">
        /// End date for the date range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemDates2(
            string? from,
            string? to)
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemDates2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant2PropertiesWorkHistoryItemDates2()
        {
        }

    }
}