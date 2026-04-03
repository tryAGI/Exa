
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FindSimilarRequest2
    {
        /// <summary>
        /// The url for which you would like to find similar links.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </summary>
        /// <example>https://arxiv.org/abs/2307.06435</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// If true, excludes links from the same domain as the provided URL from the results.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludeSourceDomain")]
        public bool? ExcludeSourceDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest2" /> class.
        /// </summary>
        /// <param name="url">
        /// The url for which you would like to find similar links.<br/>
        /// Example: https://arxiv.org/abs/2307.06435
        /// </param>
        /// <param name="excludeSourceDomain">
        /// If true, excludes links from the same domain as the provided URL from the results.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarRequest2(
            string url,
            bool? excludeSourceDomain)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExcludeSourceDomain = excludeSourceDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarRequest2" /> class.
        /// </summary>
        public FindSimilarRequest2()
        {
        }
    }
}