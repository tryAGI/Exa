
#nullable enable

namespace Exa
{
    /// <summary>
    /// Concurrency limits for the team.
    /// </summary>
    public sealed partial class WebsetsTeamInfoLimits
    {
        /// <summary>
        /// Maximum number of concurrent requests allowed. Null means unlimited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxConcurrent")]
        public int? MaxConcurrent { get; set; }

        /// <summary>
        /// Maximum number of queued requests allowed. Null means unlimited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxQueued")]
        public int? MaxQueued { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetsTeamInfoLimits" /> class.
        /// </summary>
        /// <param name="maxConcurrent">
        /// Maximum number of concurrent requests allowed. Null means unlimited.
        /// </param>
        /// <param name="maxQueued">
        /// Maximum number of queued requests allowed. Null means unlimited.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetsTeamInfoLimits(
            int? maxConcurrent,
            int? maxQueued)
        {
            this.MaxConcurrent = maxConcurrent;
            this.MaxQueued = maxQueued;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetsTeamInfoLimits" /> class.
        /// </summary>
        public WebsetsTeamInfoLimits()
        {
        }

    }
}