
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsetsTeamInfo
    {
        /// <summary>
        /// The object type, always `"team"`.
        /// </summary>
        /// <default>"team"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "team";

        /// <summary>
        /// Unique identifier for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Current concurrency usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetsTeamInfoConcurrency Concurrency { get; set; }

        /// <summary>
        /// Concurrency limits for the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.WebsetsTeamInfoLimits Limits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetsTeamInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the team.
        /// </param>
        /// <param name="name">
        /// Name of the team.
        /// </param>
        /// <param name="concurrency">
        /// Current concurrency usage.
        /// </param>
        /// <param name="limits">
        /// Concurrency limits for the team.
        /// </param>
        /// <param name="object">
        /// The object type, always `"team"`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebsetsTeamInfo(
            string id,
            string name,
            global::Exa.WebsetsTeamInfoConcurrency concurrency,
            global::Exa.WebsetsTeamInfoLimits limits,
            string @object = "team")
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Concurrency = concurrency ?? throw new global::System.ArgumentNullException(nameof(concurrency));
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsetsTeamInfo" /> class.
        /// </summary>
        public WebsetsTeamInfo()
        {
        }

    }
}