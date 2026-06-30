
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetItemPersonPropertiesPersonCompany
    {
        /// <summary>
        /// The name of the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The location the person is working at the company
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonCompany" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the company
        /// </param>
        /// <param name="location">
        /// The location the person is working at the company
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetItemPersonPropertiesPersonCompany(
            string name,
            string? location)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetItemPersonPropertiesPersonCompany" /> class.
        /// </summary>
        public WebsetItemPersonPropertiesPersonCompany()
        {
        }

    }
}