
#nullable enable

namespace Exa
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnswerResult
    {
        /// <summary>
        /// The generated answer based on search results. Returns a string by default, or a structured object matching the provided outputSchema.<br/>
        /// Example: $350 billion.
        /// </summary>
        /// <example>$350 billion.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, object>))]
        public global::Exa.OneOf<string, object>? Answer { get; set; }

        /// <summary>
        /// Search results used to generate the answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Exa.AnswerCitation>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResult" /> class.
        /// </summary>
        /// <param name="answer">
        /// The generated answer based on search results. Returns a string by default, or a structured object matching the provided outputSchema.<br/>
        /// Example: $350 billion.
        /// </param>
        /// <param name="citations">
        /// Search results used to generate the answer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerResult(
            global::Exa.OneOf<string, object>? answer,
            global::System.Collections.Generic.IList<global::Exa.AnswerCitation>? citations)
        {
            this.Answer = answer;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResult" /> class.
        /// </summary>
        public AnswerResult()
        {
        }
    }
}