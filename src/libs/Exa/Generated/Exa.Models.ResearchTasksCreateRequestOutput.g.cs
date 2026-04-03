
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchTasksCreateRequestOutput
    {
        /// <summary>
        /// A JsonSchema specification of the desired output. See https://json-schema.org/draft-07.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// When set to true and no output schema is provided, an LLM will generate an output schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inferSchema")]
        public bool? InferSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTasksCreateRequestOutput" /> class.
        /// </summary>
        /// <param name="schema">
        /// A JsonSchema specification of the desired output. See https://json-schema.org/draft-07.
        /// </param>
        /// <param name="inferSchema">
        /// When set to true and no output schema is provided, an LLM will generate an output schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchTasksCreateRequestOutput(
            object? schema,
            bool? inferSchema)
        {
            this.Schema = schema;
            this.InferSchema = inferSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTasksCreateRequestOutput" /> class.
        /// </summary>
        public ResearchTasksCreateRequestOutput()
        {
        }
    }
}