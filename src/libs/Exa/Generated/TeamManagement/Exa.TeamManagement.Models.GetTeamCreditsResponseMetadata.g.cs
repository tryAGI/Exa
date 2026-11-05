
#nullable enable

namespace Exa.TeamManagement
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetTeamCreditsResponseMetadata
    {
        /// <summary>
        /// When this response was generated. The balance in it can be up to 5 minutes older.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at")]
        public global::System.DateTime? GeneratedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamCreditsResponseMetadata" /> class.
        /// </summary>
        /// <param name="generatedAt">
        /// When this response was generated. The balance in it can be up to 5 minutes older.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTeamCreditsResponseMetadata(
            global::System.DateTime? generatedAt)
        {
            this.GeneratedAt = generatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTeamCreditsResponseMetadata" /> class.
        /// </summary>
        public GetTeamCreditsResponseMetadata()
        {
        }

    }
}