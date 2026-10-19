
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SummaryWithMaxTokensOptionsOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Deprecated. Maximum tokens for the generated summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokens")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryWithMaxTokensOptionsOutput" /> class.
        /// </summary>
        /// <param name="query"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SummaryWithMaxTokensOptionsOutput(
            string? query)
        {
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SummaryWithMaxTokensOptionsOutput" /> class.
        /// </summary>
        public SummaryWithMaxTokensOptionsOutput()
        {
        }

    }
}