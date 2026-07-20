
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemPersonPropertiesPersonWorkHistoryItem
    {
        /// <summary>
        /// Job title or position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Work location
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Employment dates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dates")]
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemDates? Dates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemCompany? Company { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonWorkHistoryItem" /> class.
        /// </summary>
        /// <param name="title">
        /// Job title or position
        /// </param>
        /// <param name="location">
        /// Work location
        /// </param>
        /// <param name="dates">
        /// Employment dates
        /// </param>
        /// <param name="company"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemPersonPropertiesPersonWorkHistoryItem(
            string? title,
            string? location,
            global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemDates? dates,
            global::Exa.WebsetItemPersonPropertiesPersonWorkHistoryItemCompany? company)
        {
            this.Title = title;
            this.Location = location;
            this.Dates = dates;
            this.Company = company;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonWorkHistoryItem" /> class.
        /// </summary>
        public WebsetItemPersonPropertiesPersonWorkHistoryItem()
        {
        }

    }
}