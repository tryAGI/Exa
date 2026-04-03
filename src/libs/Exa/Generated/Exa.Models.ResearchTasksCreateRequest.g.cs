
#nullable enable

namespace Exa
{
    /// <summary>
    /// Example: {"instructions":"What species of ant are similar to honeypot ants?","model":"exa-research","output":{"schema":{"type":"object","properties":{"answer":{"type":"string"}}}}}
    /// </summary>
    public sealed partial class ResearchTasksCreateRequest
    {
        /// <summary>
        /// Instructions for what the research task should accomplish
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// Default Value: exa-research
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchTasksCreateRequestModelJsonConverter))]
        public global::Exa.ResearchTasksCreateRequestModel? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::Exa.ResearchTasksCreateRequestOutput? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTasksCreateRequest" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Instructions for what the research task should accomplish
        /// </param>
        /// <param name="model">
        /// Default Value: exa-research
        /// </param>
        /// <param name="output"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchTasksCreateRequest(
            string instructions,
            global::Exa.ResearchTasksCreateRequestModel? model,
            global::Exa.ResearchTasksCreateRequestOutput? output)
        {
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Model = model;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTasksCreateRequest" /> class.
        /// </summary>
        public ResearchTasksCreateRequest()
        {
        }
    }
}