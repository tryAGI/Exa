
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchPersonEntityOutputPropertiesEducationHistoryItem
    {
        /// <summary>
        /// Degree or credential.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("degree")]
        public string? Degree { get; set; }

        /// <summary>
        /// Education date range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dates")]
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemDates? Dates { get; set; }

        /// <summary>
        /// Education institution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("institution")]
        public global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemInstitution? Institution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPersonEntityOutputPropertiesEducationHistoryItem" /> class.
        /// </summary>
        /// <param name="degree">
        /// Degree or credential.
        /// </param>
        /// <param name="dates">
        /// Education date range.
        /// </param>
        /// <param name="institution">
        /// Education institution.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchPersonEntityOutputPropertiesEducationHistoryItem(
            string? degree,
            global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemDates? dates,
            global::Exa.SearchPersonEntityOutputPropertiesEducationHistoryItemInstitution? institution)
        {
            this.Degree = degree;
            this.Dates = dates;
            this.Institution = institution;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchPersonEntityOutputPropertiesEducationHistoryItem" /> class.
        /// </summary>
        public SearchPersonEntityOutputPropertiesEducationHistoryItem()
        {
        }

    }
}