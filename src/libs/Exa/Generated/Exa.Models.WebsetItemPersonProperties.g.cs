
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemPersonProperties
    {
        /// <summary>
        /// Default Value: person
        /// </summary>
        /// <default>"person"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "person";

        /// <summary>
        /// The URL of the person profile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Short description of the relevance of the person
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetItemPersonPropertiesPerson Person { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonProperties" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the person profile
        /// </param>
        /// <param name="description">
        /// Short description of the relevance of the person
        /// </param>
        /// <param name="person"></param>
        /// <param name="type">
        /// Default Value: person
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemPersonProperties(
            string url,
            string description,
            global::Exa.WebsetItemPersonPropertiesPerson person,
            string type = "person")
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Person = person ?? throw new global::System.ArgumentNullException(nameof(person));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonProperties" /> class.
        /// </summary>
        public WebsetItemPersonProperties()
        {
        }

    }
}