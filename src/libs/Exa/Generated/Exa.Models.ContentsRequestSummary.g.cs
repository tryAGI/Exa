
#nullable enable

namespace Exa
{
    /// <summary>
    /// Summary of the webpage.
    /// </summary>
    public sealed partial class ContentsRequestSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestSummary" /> class.
        /// </summary>
        /// <param name="query"></param>
        /// <param name="schema"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestSummary(
            string? query,
            global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>? schema)
        {
            this.Query = query;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestSummary" /> class.
        /// </summary>
        public ContentsRequestSummary()
        {
        }

    }
}