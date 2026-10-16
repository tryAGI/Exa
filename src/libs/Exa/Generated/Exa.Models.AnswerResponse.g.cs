
#nullable enable

namespace Exa
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnswerResponse
    {
        /// <summary>
        /// Unique identifier for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The generated answer based on search results. Returns a string by default, or a structured object matching the provided outputSchema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Exa.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Exa.OneOf<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>> Answer { get; set; }

        /// <summary>
        /// Search results used to generate the answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Exa.AnswerResponseCitation>? Citations { get; set; }

        /// <summary>
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("costDollars")]
        public global::Exa.CostDollarsOutput? CostDollars { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResponse" /> class.
        /// </summary>
        /// <param name="answer">
        /// The generated answer based on search results. Returns a string by default, or a structured object matching the provided outputSchema.
        /// </param>
        /// <param name="requestId">
        /// Unique identifier for the request.
        /// </param>
        /// <param name="citations">
        /// Search results used to generate the answer.
        /// </param>
        /// <param name="costDollars">
        /// Estimated dollar cost of the request. Which fields appear depends on the endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnswerResponse(
            global::Exa.OneOf<string, global::System.Collections.Generic.Dictionary<string, global::Exa.JsonValue?>> answer,
            string? requestId,
            global::System.Collections.Generic.IList<global::Exa.AnswerResponseCitation>? citations,
            global::Exa.CostDollarsOutput? costDollars)
        {
            this.RequestId = requestId;
            this.Answer = answer;
            this.Citations = citations;
            this.CostDollars = costDollars;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnswerResponse" /> class.
        /// </summary>
        public AnswerResponse()
        {
        }

    }
}