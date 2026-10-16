
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FindSimilarResultExtrasCodeBlock
    {
        /// <summary>
        /// The contents of the code block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The language the code block is annotated with, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResultExtrasCodeBlock" /> class.
        /// </summary>
        /// <param name="text">
        /// The contents of the code block.
        /// </param>
        /// <param name="source">
        /// The language the code block is annotated with, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FindSimilarResultExtrasCodeBlock(
            string text,
            string source)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FindSimilarResultExtrasCodeBlock" /> class.
        /// </summary>
        public FindSimilarResultExtrasCodeBlock()
        {
        }

    }
}