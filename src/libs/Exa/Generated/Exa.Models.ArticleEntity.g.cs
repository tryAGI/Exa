
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArticleEntity
    {
        /// <summary>
        /// Default Value: article
        /// </summary>
        /// <default>"article"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "article";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleEntity" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: article
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArticleEntity(
            string type = "article")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleEntity" /> class.
        /// </summary>
        public ArticleEntity()
        {
        }

    }
}