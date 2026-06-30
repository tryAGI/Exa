
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAgentRunResponse
    {
        /// <summary>
        /// Agent run ID. New run IDs are returned with the `agent_run_` prefix.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </summary>
        /// <example>agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"agent_run.deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "agent_run.deleted";

        /// <summary>
        /// 
        /// </summary>
        /// <default>true</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool Deleted { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAgentRunResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Agent run ID. New run IDs are returned with the `agent_run_` prefix.<br/>
        /// Example: agent_run_01j7x9v0m2n4p6q8r0s2t4v6w8
        /// </param>
        /// <param name="object"></param>
        /// <param name="deleted"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAgentRunResponse(
            string id,
            string @object = "agent_run.deleted",
            bool deleted = true)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAgentRunResponse" /> class.
        /// </summary>
        public DeleteAgentRunResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="DeleteAgentRunResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static DeleteAgentRunResponse FromId(string id)
        {
            return new DeleteAgentRunResponse
            {
                Id = id,
            };
        }

    }
}