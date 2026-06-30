
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchResultOutputEntitieVariant1PropertiesWebTraffic2
    {
        /// <summary>
        /// Estimated monthly website visits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visitsMonthly")]
        public double? VisitsMonthly { get; set; }

        /// <summary>
        /// Estimated website traffic rank within the company's primary country.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryRank")]
        public int? CountryRank { get; set; }

        /// <summary>
        /// Estimated average visit duration, in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avgDurationSeconds")]
        public double? AvgDurationSeconds { get; set; }

        /// <summary>
        /// Historical monthly website visits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem> History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesWebTraffic2" /> class.
        /// </summary>
        /// <param name="history">
        /// Historical monthly website visits.
        /// </param>
        /// <param name="visitsMonthly">
        /// Estimated monthly website visits.
        /// </param>
        /// <param name="countryRank">
        /// Estimated website traffic rank within the company's primary country.
        /// </param>
        /// <param name="avgDurationSeconds">
        /// Estimated average visit duration, in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultOutputEntitieVariant1PropertiesWebTraffic2(
            global::System.Collections.Generic.IList<global::Exa.SearchResultOutputEntitieVariant1PropertiesWebTrafficHistoryItem> history,
            double? visitsMonthly,
            int? countryRank,
            double? avgDurationSeconds)
        {
            this.VisitsMonthly = visitsMonthly;
            this.CountryRank = countryRank;
            this.AvgDurationSeconds = avgDurationSeconds;
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultOutputEntitieVariant1PropertiesWebTraffic2" /> class.
        /// </summary>
        public SearchResultOutputEntitieVariant1PropertiesWebTraffic2()
        {
        }

    }
}