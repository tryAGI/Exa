
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant4ContentCsMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public double? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public double? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checked_at")]
        public global::System.DateTime? CheckedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changed_at")]
        public global::System.DateTime? ChangedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experience_change_last_identified_at")]
        public global::System.DateTime? ExperienceChangeLastIdentifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_parent")]
        public bool? IsParent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentCsMetadata" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="parentId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="checkedAt"></param>
        /// <param name="changedAt"></param>
        /// <param name="experienceChangeLastIdentifiedAt"></param>
        /// <param name="isDeleted"></param>
        /// <param name="isParent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant4ContentCsMetadata(
            double? id,
            double? parentId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.DateTime? checkedAt,
            global::System.DateTime? changedAt,
            global::System.DateTime? experienceChangeLastIdentifiedAt,
            bool? isDeleted,
            bool? isParent)
        {
            this.Id = id;
            this.ParentId = parentId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CheckedAt = checkedAt;
            this.ChangedAt = changedAt;
            this.ExperienceChangeLastIdentifiedAt = experienceChangeLastIdentifiedAt;
            this.IsDeleted = isDeleted;
            this.IsParent = isParent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant4ContentCsMetadata" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant4ContentCsMetadata()
        {
        }

    }
}