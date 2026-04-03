
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResearchTasksCreateResponse
    {
        /// <summary>
        /// The unique identifier for the research task<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </summary>
        /// <example>a1b2c3d4-e5f6-7890-abcd-ef1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTasksCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the research task<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchTasksCreateResponse(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTasksCreateResponse" /> class.
        /// </summary>
        public ResearchTasksCreateResponse()
        {
        }
    }
}