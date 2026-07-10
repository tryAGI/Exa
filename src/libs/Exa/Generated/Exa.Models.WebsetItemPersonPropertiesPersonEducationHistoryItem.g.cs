
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemPersonPropertiesPersonEducationHistoryItem
    {
        /// <summary>
        /// Degree obtained
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("degree")]
        public string? Degree { get; set; }

        /// <summary>
        /// Education dates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dates")]
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemDates? Dates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("institution")]
        public global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution? Institution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonEducationHistoryItem" /> class.
        /// </summary>
        /// <param name="degree">
        /// Degree obtained
        /// </param>
        /// <param name="dates">
        /// Education dates
        /// </param>
        /// <param name="institution"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemPersonPropertiesPersonEducationHistoryItem(
            string? degree,
            global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemDates? dates,
            global::Exa.WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution? institution)
        {
            this.Degree = degree;
            this.Dates = dates;
            this.Institution = institution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonEducationHistoryItem" /> class.
        /// </summary>
        public WebsetItemPersonPropertiesPersonEducationHistoryItem()
        {
        }

    }
}