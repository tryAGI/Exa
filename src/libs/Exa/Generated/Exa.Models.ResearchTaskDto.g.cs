
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchTaskDto
    {
        /// <summary>
        /// The unique identifier for the research task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The current status of the research task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchTaskDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.ResearchTaskDtoStatus Status { get; set; }

        /// <summary>
        /// The instructions or query for the research task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Instructions { get; set; }

        /// <summary>
        /// The JSON schema specification for the expected output format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// The research results data conforming to the specified schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Citations grouped by the root field they were used in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Exa.ResearchTaskDtoCitation>>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTaskDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the research task
        /// </param>
        /// <param name="status">
        /// The current status of the research task
        /// </param>
        /// <param name="instructions">
        /// The instructions or query for the research task
        /// </param>
        /// <param name="schema">
        /// The JSON schema specification for the expected output format
        /// </param>
        /// <param name="data">
        /// The research results data conforming to the specified schema
        /// </param>
        /// <param name="citations">
        /// Citations grouped by the root field they were used in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchTaskDto(
            string id,
            global::Exa.ResearchTaskDtoStatus status,
            string instructions,
            object? schema,
            object? data,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Exa.ResearchTaskDtoCitation>>? citations)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Schema = schema;
            this.Data = data;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTaskDto" /> class.
        /// </summary>
        public ResearchTaskDto()
        {
        }
    }
}