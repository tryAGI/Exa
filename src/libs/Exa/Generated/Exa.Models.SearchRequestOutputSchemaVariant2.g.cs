
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchRequestOutputSchemaVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"object"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "object";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
        public bool? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestOutputSchemaVariant2" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="properties"></param>
        /// <param name="required"></param>
        /// <param name="additionalProperties"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRequestOutputSchemaVariant2(
            string? description,
            object? properties,
            global::System.Collections.Generic.IList<string>? required,
            bool? additionalProperties,
            string type = "object")
        {
            this.Type = type;
            this.Description = description;
            this.Properties = properties;
            this.Required = required;
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequestOutputSchemaVariant2" /> class.
        /// </summary>
        public SearchRequestOutputSchemaVariant2()
        {
        }

    }
}