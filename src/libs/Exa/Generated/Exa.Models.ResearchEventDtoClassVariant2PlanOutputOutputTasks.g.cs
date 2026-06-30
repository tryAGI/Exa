
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchEventDtoClassVariant2PlanOutputOutputTasks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputTypeJsonConverter))]
        public global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType OutputType { get; set; }

        /// <summary>
        /// Why these specific tasks were chosen
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reasoning { get; set; }

        /// <summary>
        /// List of task instructions that will be executed in parallel
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasksInstructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TasksInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOutputOutputTasks" /> class.
        /// </summary>
        /// <param name="reasoning">
        /// Why these specific tasks were chosen
        /// </param>
        /// <param name="tasksInstructions">
        /// List of task instructions that will be executed in parallel
        /// </param>
        /// <param name="outputType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchEventDtoClassVariant2PlanOutputOutputTasks(
            string reasoning,
            global::System.Collections.Generic.IList<string> tasksInstructions,
            global::Exa.ResearchEventDtoClassVariant2PlanOutputOutputTasksOutputType outputType)
        {
            this.OutputType = outputType;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.TasksInstructions = tasksInstructions ?? throw new global::System.ArgumentNullException(nameof(tasksInstructions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchEventDtoClassVariant2PlanOutputOutputTasks" /> class.
        /// </summary>
        public ResearchEventDtoClassVariant2PlanOutputOutputTasks()
        {
        }

    }
}