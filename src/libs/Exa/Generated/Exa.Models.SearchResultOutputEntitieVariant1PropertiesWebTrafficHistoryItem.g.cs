
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem
    {
        /// <summary>
        /// Estimated monthly visits for this period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Start month for this value, formatted as YYYY-MM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateFrom")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DateFrom { get; set; }

        /// <summary>
        /// End month for this value, formatted as YYYY-MM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dateTo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DateTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem" /> class.
        /// </summary>
        /// <param name="value">
        /// Estimated monthly visits for this period.
        /// </param>
        /// <param name="dateFrom">
        /// Start month for this value, formatted as YYYY-MM.
        /// </param>
        /// <param name="dateTo">
        /// End month for this value, formatted as YYYY-MM.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem(
            double value,
            string dateFrom,
            string dateTo)
        {
            this.Value = value;
            this.DateFrom = dateFrom ?? throw new global::System.ArgumentNullException(nameof(dateFrom));
            this.DateTo = dateTo ?? throw new global::System.ArgumentNullException(nameof(dateTo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem()
        {
        }

    }
}