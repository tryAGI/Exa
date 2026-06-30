
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemCompanyProperties
    {
        /// <summary>
        /// Default Value: company
        /// </summary>
        /// <default>"company"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "company";

        /// <summary>
        /// The URL of the company website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Short description of the relevance of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The text content of the company website
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetItemCompanyPropertiesCompany Company { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyProperties" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the company website
        /// </param>
        /// <param name="description">
        /// Short description of the relevance of the company
        /// </param>
        /// <param name="company"></param>
        /// <param name="content">
        /// The text content of the company website
        /// </param>
        /// <param name="type">
        /// Default Value: company
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemCompanyProperties(
            string url,
            string description,
            global::Exa.WebsetItemCompanyPropertiesCompany company,
            string? content,
            string type = "company")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Content = content;
            this.Company = company ?? throw new global::System.ArgumentNullException(nameof(company));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemCompanyProperties" /> class.
        /// </summary>
        public WebsetItemCompanyProperties()
        {
        }

    }
}