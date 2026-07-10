
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution
    {
        /// <summary>
        /// Entity ID of the institution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Institution name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// LinkedIn URL of the institution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedinUrl")]
        public string? LinkedinUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution" /> class.
        /// </summary>
        /// <param name="id">
        /// Entity ID of the institution
        /// </param>
        /// <param name="name">
        /// Institution name
        /// </param>
        /// <param name="linkedinUrl">
        /// LinkedIn URL of the institution
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution(
            string? id,
            string? name,
            string? linkedinUrl)
        {
            this.Id = id;
            this.Name = name;
            this.LinkedinUrl = linkedinUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution" /> class.
        /// </summary>
        public WebsetItemPersonPropertiesPersonEducationHistoryItemInstitution()
        {
        }

    }
}