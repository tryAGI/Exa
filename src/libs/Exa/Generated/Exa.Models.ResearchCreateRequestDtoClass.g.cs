
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchCreateRequestDtoClass
    {
        /// <summary>
        /// Research model to use. exa-research is faster and cheaper, while exa-research-pro provides more thorough analysis and stronger reasoning.<br/>
        /// Default Value: exa-research
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchCreateRequestDtoClassModelJsonConverter))]
        public global::Exa.ResearchCreateRequestDtoClassModel? Model { get; set; }

        /// <summary>
        /// Instructions for what you would like research on. A good prompt clearly defines what information you want to find, how research should be conducted, and what the output should look like.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// JSON Schema to enforce structured output. When provided, the research output will be validated against this schema and returned as parsed JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSchema")]
        public object? OutputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchCreateRequestDtoClass" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Instructions for what you would like research on. A good prompt clearly defines what information you want to find, how research should be conducted, and what the output should look like.
        /// </param>
        /// <param name="model">
        /// Research model to use. exa-research is faster and cheaper, while exa-research-pro provides more thorough analysis and stronger reasoning.<br/>
        /// Default Value: exa-research
        /// </param>
        /// <param name="outputSchema">
        /// JSON Schema to enforce structured output. When provided, the research output will be validated against this schema and returned as parsed JSON.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchCreateRequestDtoClass(
            string instructions,
            global::Exa.ResearchCreateRequestDtoClassModel? model,
            object? outputSchema)
        {
            this.Model = model;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputSchema = outputSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchCreateRequestDtoClass" /> class.
        /// </summary>
        public ResearchCreateRequestDtoClass()
        {
        }

    }
}