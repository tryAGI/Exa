
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedCitationProfileVariant3ContentMetaData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_changed")]
        public string? LastChanged { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_version")]
        public string? SchemaVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProfileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant3ContentMetaData" /> class.
        /// </summary>
        /// <param name="profileId"></param>
        /// <param name="lastChanged"></param>
        /// <param name="schemaVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedCitationProfileVariant3ContentMetaData(
            string profileId,
            string? lastChanged,
            string? schemaVersion)
        {
            this.LastChanged = lastChanged;
            this.SchemaVersion = schemaVersion;
            this.ProfileId = profileId ?? throw new global::System.ArgumentNullException(nameof(profileId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedCitationProfileVariant3ContentMetaData" /> class.
        /// </summary>
        public ResearchDtoClassCompletedCitationProfileVariant3ContentMetaData()
        {
        }

    }
}