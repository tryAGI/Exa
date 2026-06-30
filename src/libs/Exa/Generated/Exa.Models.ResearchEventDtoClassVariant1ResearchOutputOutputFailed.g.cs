
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant1ResearchOutputOutputFailed
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType OutputType { get; set; }

        /// <summary>
        /// Detailed error message explaining why the research failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchOutputOutputFailed" /> class.
        /// </summary>
        /// <param name="error">
        /// Detailed error message explaining why the research failed
        /// </param>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant1ResearchOutputOutputFailed(
            string error,
            global::Exa.ResearchEventDtoClassVariant1ResearchOutputOutputFailedOutputType outputType)
        {
            this.OutputType = outputType;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant1ResearchOutputOutputFailed" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant1ResearchOutputOutputFailed()
        {
        }

    }
}