
#nullable enable

namespace Exa
{
    /// <summary>
    /// Current concurrency usage.
    /// </summary>
    public sealed partial class WebsetsTeamInfoConcurrency
    {
        /// <summary>
        /// Number of requests currently being processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Active { get; set; }

        /// <summary>
        /// Number of requests currently queued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Queued { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetsTeamInfoConcurrency" /> class.
        /// </summary>
        /// <param name="active">
        /// Number of requests currently being processed.
        /// </param>
        /// <param name="queued">
        /// Number of requests currently queued.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetsTeamInfoConcurrency(
            int active,
            int queued)
        {
            this.Active = active;
            this.Queued = queued;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetsTeamInfoConcurrency" /> class.
        /// </summary>
        public WebsetsTeamInfoConcurrency()
        {
        }

    }
}