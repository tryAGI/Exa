
#nullable enable

namespace Exa
{
    /// <summary>
    /// The final research results, containing both raw text and parsed JSON if outputSchema was provided
    /// </summary>
    public sealed partial class ResearchDtoClassCompletedOutput
    {
        /// <summary>
        /// The complete research output as text. If outputSchema was provided, this is a JSON string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Structured JSON object matching your outputSchema. Only present when outputSchema was provided and the output successfully validated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsed")]
        public object? Parsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedOutput" /> class.
        /// </summary>
        /// <param name="content">
        /// The complete research output as text. If outputSchema was provided, this is a JSON string.
        /// </param>
        /// <param name="parsed">
        /// Structured JSON object matching your outputSchema. Only present when outputSchema was provided and the output successfully validated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchDtoClassCompletedOutput(
            string content,
            object? parsed)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Parsed = parsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchDtoClassCompletedOutput" /> class.
        /// </summary>
        public ResearchDtoClassCompletedOutput()
        {
        }

    }
}