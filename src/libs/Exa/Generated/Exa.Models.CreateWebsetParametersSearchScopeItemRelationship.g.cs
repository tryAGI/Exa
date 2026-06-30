
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWebsetParametersSearchScopeItemRelationship
    {
        /// <summary>
        /// What the relationship of the entities you hope to find is relative to the entities contained in the provided source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Definition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetParametersSearchScopeItemRelationship" /> class.
        /// </summary>
        /// <param name="definition">
        /// What the relationship of the entities you hope to find is relative to the entities contained in the provided source.
        /// </param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWebsetParametersSearchScopeItemRelationship(
            string definition,
            double limit)
        {
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebsetParametersSearchScopeItemRelationship" /> class.
        /// </summary>
        public CreateWebsetParametersSearchScopeItemRelationship()
        {
        }

    }
}