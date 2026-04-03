
#nullable enable

namespace Exa
{
    /// <summary>
    /// A [JSON Schema Draft 7](https://json-schema.org/draft-07) specification for the desired answer structure. When provided, the answer will be returned as a structured object matching the schema instead of a plain string.
    /// </summary>
    public sealed partial class AnswerRequestOutputSchema
    {
        /// <summary>
        /// The root schema type (typically "object").<br/>
        /// Example: object
        /// </summary>
        /// <example>object</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// An object where each key is a property name and each value is a JSON Schema describing that property (with `type`, `description`, etc).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public object? Properties { get; set; }

        /// <summary>
        /// List of required property names.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public global::System.Collections.Generic.IList<string>? Required { get; set; }

        /// <summary>
        /// A description of the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether to allow properties not listed in `properties`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalProperties")]
        public bool? AdditionalProperties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties2 { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerRequestOutputSchema" /> class.
        /// </summary>
        /// <param name="type">
        /// The root schema type (typically "object").<br/>
        /// Example: object
        /// </param>
        /// <param name="properties">
        /// An object where each key is a property name and each value is a JSON Schema describing that property (with `type`, `description`, etc).
        /// </param>
        /// <param name="required">
        /// List of required property names.
        /// </param>
        /// <param name="description">
        /// A description of the schema.
        /// </param>
        /// <param name="additionalProperties">
        /// Whether to allow properties not listed in `properties`.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerRequestOutputSchema(
            string? type,
            object? properties,
            global::System.Collections.Generic.IList<string>? required,
            string? description,
            bool? additionalProperties)
        {
            this.Type = type;
            this.Properties = properties;
            this.Required = required;
            this.Description = description;
            this.AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerRequestOutputSchema" /> class.
        /// </summary>
        public AnswerRequestOutputSchema()
        {
        }
    }
}