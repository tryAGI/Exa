
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_name")]
        public string? FieldName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("change_type")]
        public string? ChangeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_changed_at")]
        public global::System.DateTime? LastChangedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem" /> class.
        /// </summary>
        /// <param name="fieldName"></param>
        /// <param name="changeType"></param>
        /// <param name="lastChangedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem(
            string? fieldName,
            string? changeType,
            global::System.DateTime? lastChangedAt)
        {
            this.FieldName = fieldName;
            this.ChangeType = changeType;
            this.LastChangedAt = lastChangedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentProfileRootFieldChangesSummaryItem()
        {
        }

    }
}