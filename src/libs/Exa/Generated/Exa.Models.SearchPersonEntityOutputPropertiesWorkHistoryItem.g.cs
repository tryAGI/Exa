
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchPersonEntityOutputPropertiesWorkHistoryItem
    {
        /// <summary>
        /// Role title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Role location.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Role date range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dates")]
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemDates? Dates { get; set; }

        /// <summary>
        /// Company for this role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemCompany? Company { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPersonEntityOutputPropertiesWorkHistoryItem" /> class.
        /// </summary>
        /// <param name="title">
        /// Role title.
        /// </param>
        /// <param name="location">
        /// Role location.
        /// </param>
        /// <param name="dates">
        /// Role date range.
        /// </param>
        /// <param name="company">
        /// Company for this role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPersonEntityOutputPropertiesWorkHistoryItem(
            string? title,
            string? location,
            global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemDates? dates,
            global::Exa.SearchPersonEntityOutputPropertiesWorkHistoryItemCompany? company)
        {
            this.Title = title;
            this.Location = location;
            this.Dates = dates;
            this.Company = company;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPersonEntityOutputPropertiesWorkHistoryItem" /> class.
        /// </summary>
        public SearchPersonEntityOutputPropertiesWorkHistoryItem()
        {
        }

    }
}