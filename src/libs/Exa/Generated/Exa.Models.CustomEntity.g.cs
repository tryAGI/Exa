
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomEntity
    {
        /// <summary>
        /// Default Value: custom
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntity" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="type">
        /// Default Value: custom
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomEntity(
            string description,
            string type = "custom")
        {
            this.Type = type;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntity" /> class.
        /// </summary>
        public CustomEntity()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CustomEntity"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CustomEntity FromDescription(string description)
        {
            return new CustomEntity
            {
                Description = description,
            };
        }

    }
}