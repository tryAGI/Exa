
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType? OutputType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminator" /> class.
        /// </summary>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminator(
            global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminatorOutputType? outputType)
        {
            this.OutputType = outputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminator" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1ResearchOutputOutputDiscriminator()
        {
        }

    }
}