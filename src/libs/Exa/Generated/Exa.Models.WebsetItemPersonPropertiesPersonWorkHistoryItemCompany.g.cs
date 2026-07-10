
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemPersonPropertiesPersonWorkHistoryItemCompany
    {
        /// <summary>
        /// Entity ID of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Company name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// LinkedIn URL of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkedinUrl")]
        public string? LinkedinUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonWorkHistoryItemCompany" /> class.
        /// </summary>
        /// <param name="id">
        /// Entity ID of the company
        /// </param>
        /// <param name="name">
        /// Company name
        /// </param>
        /// <param name="linkedinUrl">
        /// LinkedIn URL of the company
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemPersonPropertiesPersonWorkHistoryItemCompany(
            string? id,
            string? name,
            string? linkedinUrl)
        {
            this.Id = id;
            this.Name = name;
            this.LinkedinUrl = linkedinUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonWorkHistoryItemCompany" /> class.
        /// </summary>
        public WebsetItemPersonPropertiesPersonWorkHistoryItemCompany()
        {
        }

    }
}