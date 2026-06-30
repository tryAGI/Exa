
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemPersonPropertiesPerson
    {
        /// <summary>
        /// The name of the person
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The location of the person
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// The current work position of the person
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public string? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public global::Exa.WebsetItemPersonPropertiesPersonCompany? Company { get; set; }

        /// <summary>
        /// The image URL of the person
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pictureUrl")]
        public string? PictureUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPerson" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the person
        /// </param>
        /// <param name="location">
        /// The location of the person
        /// </param>
        /// <param name="position">
        /// The current work position of the person
        /// </param>
        /// <param name="company"></param>
        /// <param name="pictureUrl">
        /// The image URL of the person
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemPersonPropertiesPerson(
            string name,
            string? location,
            string? position,
            global::Exa.WebsetItemPersonPropertiesPersonCompany? company,
            string? pictureUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Location = location;
            this.Position = position;
            this.Company = company;
            this.PictureUrl = pictureUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPerson" /> class.
        /// </summary>
        public WebsetItemPersonPropertiesPerson()
        {
        }

    }
}